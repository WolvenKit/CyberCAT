using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Core.Classes.Parsers;
using NUnit.Framework;

namespace CyberCAT.Tests
{
    public class SaveFiles
    {
        public static IEnumerable<string> SaveFileList
        {
            get
            {
                yield return "saves/sav1.dat";
                yield return "saves/sav2.dat";
                yield return "saves/pc/midgame_1.5.dat";
                yield return "saves/pc/midgame_1.6.dat";
                yield return "saves/pc/start_1.6.dat";
            }
        }

        public static IEnumerable<string> PS4SaveFileList
        {
            get
            {
                yield return "saves/ps4/ps4sav1.dat";
                yield return "saves/ps4/ps4sav2.dat";
                yield return "saves/ps4/ps4sav3.dat";
                yield return "saves/ps4/ps4sav4.dat";
                yield return "saves/ps4/ps4sav5.dat";
                yield return "saves/ps4/ps4sav6.dat";
                yield return "saves/ps4/ps4sav7.dat";
            }
        }
    }

    [TestFixtureSource(typeof(SaveFiles), "SaveFileList")]
    class PCParserTests
    {
        private readonly string _filename;
        private readonly List<INodeParser> _parsers;
        public PCParserTests(string filename)
        {
            _filename = Utils.GetFullPathToFile(filename);
            _parsers = new List<INodeParser>();
            var interfaceType = typeof(INodeParser);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass && p != typeof(DefaultParser));
            foreach (var type in types)
            {
                INodeParser instance = (INodeParser) Activator.CreateInstance(type);
                _parsers.Add(instance);
            }
        }

        [Test]
        public void ParsingNoThrowTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var newSaveFile = new SaveFile(_parsers);
            Assert.DoesNotThrow(() => { newSaveFile.LoadPCSaveFile(new MemoryStream(bytes)); });
        }

        [Test]
        public void RewritingTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var newSaveFile = new SaveFile(_parsers);
            newSaveFile.LoadPCSaveFile(new MemoryStream(bytes));
            var newBytes = newSaveFile.SaveToPCSaveFile();

            Assert.That(newBytes.Length, Is.EqualTo(bytes.Length));
            Assert.That(newBytes.SequenceEqual(bytes), Is.True);
        }

        [Test]
        public void FactsAddingTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var saveFile = new SaveFile(_parsers);
            saveFile.LoadPCSaveFile(new MemoryStream(bytes));

            var prevNodeCount = saveFile.FlatNodes.Count;
            var fdb = saveFile.FlatNodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.FACTSDB);
            Assert.That(fdb, Is.Not.Null);

            var firstTable = ((FactsDB)fdb.Value).FactsTables[0];
            firstTable.FactEntries.Add(new FactsTable.FactEntry { Hash = 0x42424242, Value = 1}); // Bogus data for testing
            var factCount = firstTable.FactEntries.Count;

            List<byte[]> newSave = new List<byte[]>(); // we need the array but cannot assign a variable inside the delegate
            Assert.DoesNotThrow(() => { newSave.Add(saveFile.SaveToPCSaveFile()); });

            saveFile = new SaveFile();
            using (var stream = new MemoryStream(newSave[0]))
            {
                Assert.DoesNotThrow(() => { saveFile.LoadPCSaveFile(stream); });
            }

            Assert.That(saveFile.FlatNodes.Count, Is.EqualTo(prevNodeCount));

            fdb = saveFile.FlatNodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.FACTSDB);
            Assert.That(fdb, Is.Not.Null);

            firstTable = ((FactsDB)fdb.Value).FactsTables[0];
            var newFactCount = firstTable.FactEntries.Count;

            Assert.That(factCount, Is.EqualTo(newFactCount));
        }

        [Test]
        public void FactsRemovingTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var saveFile = new SaveFile(_parsers);
            saveFile.LoadPCSaveFile(new MemoryStream(bytes));

            var prevNodeCount = saveFile.FlatNodes.Count;
            var fdb = saveFile.FlatNodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.FACTSDB);
            Assert.That(fdb, Is.Not.Null);

            var firstTable = ((FactsDB)fdb.Value).FactsTables[0];
            firstTable.FactEntries.RemoveAt(0);
            var factCount = firstTable.FactEntries.Count;

            List<byte[]> newSave = new List<byte[]>(); // we need the array but cannot assign a variable inside the delegate
            Assert.DoesNotThrow(() => { newSave.Add(saveFile.SaveToPCSaveFile()); });

            saveFile = new SaveFile();
            using (var stream = new MemoryStream(newSave[0]))
            {
                Assert.DoesNotThrow(() => { saveFile.LoadPCSaveFile(stream); });
            }

            Assert.That(saveFile.FlatNodes.Count, Is.EqualTo(prevNodeCount));

            fdb = saveFile.FlatNodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.FACTSDB);
            Assert.That(fdb, Is.Not.Null);

            firstTable = ((FactsDB)fdb.Value).FactsTables[0];
            var newFactCount = firstTable.FactEntries.Count;

            Assert.That(factCount, Is.EqualTo(newFactCount));
        }
    }

    class SpecificSaveFileTests
    {
        [Test]
        public void CharacterAppearanceSectionAddingTest()
        {
            // Savefile pc/midgame_1.5.dat has no eyes section in TPP's AdditionalList.
            // Add those and see if the result is written ok.
            var filePath = Utils.GetFullPathToFile("saves/pc/midgame_1.5.dat");
            var bytes = File.ReadAllBytes(filePath);

            var fileStream = new MemoryStream(bytes);

            var saveFile = new SaveFile();
            saveFile.LoadPCSaveFile(fileStream);

            var prevNodeCount = saveFile.FlatNodes.Count;

            var cas = saveFile.Nodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.CHARACTER_CUSTOMIZATION_APPEARANCES_NODE);
            Assert.That(cas, Is.Not.Null);

            var prevOffset = cas.Offset;
            var prevSize = cas.Size;

            var prevOffsets = new Dictionary<int, int>();
            var nodesAfterCas = saveFile.FlatNodes.Where(_ => _.Id > cas.Id);
            foreach (var node in nodesAfterCas)
            {
                prevOffsets.Add(node.Id, node.Offset);
            }

            var value = (CharacterCustomizationAppearances)cas.Value;

            var tpp = value.FirstSection.AppearanceSections[0];
            tpp.AdditionalList.Add(new CharacterCustomizationAppearances.ValueEntry {FirstString = "eyes", SecondString = "h071"});

            List<byte[]> newSave = new List<byte[]>(); // we need the array but cannot assign a variable inside the delegate
            Assert.DoesNotThrow(() => { newSave.Add(saveFile.SaveToPCSaveFile()); });

            saveFile = new SaveFile();
            using (var stream = new MemoryStream(newSave[0]))
            {
                Assert.DoesNotThrow(() => { saveFile.LoadPCSaveFile(stream); });
            }

            Assert.That(saveFile.FlatNodes.Count, Is.EqualTo(prevNodeCount));

            var addedBytes = 18; // The new entry adds 5 + 5 + 8 = 18 bytes

            cas = saveFile.Nodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.CHARACTER_CUSTOMIZATION_APPEARANCES_NODE);
            Assert.That(cas, Is.Not.Null);
            Assert.That(cas.Offset, Is.EqualTo(prevOffset)); // Offset should not have changed
            Assert.That(cas.Size, Is.EqualTo(prevSize + addedBytes)); // But size should have changed

            nodesAfterCas = saveFile.FlatNodes.Where(_ => _.Id > cas.Id);
            foreach (var node in nodesAfterCas)
            {
                // Each node offset after CAS should have moved by 18 bytes.
                Assert.That(node.Offset, Is.EqualTo(prevOffsets[node.Id] + addedBytes));
            }
        }

        [Test]
        public void RemovingItemModTest()
        {
            var filePath = Utils.GetFullPathToFile("saves/pc/midgame_1.5.dat");
            var bytes = File.ReadAllBytes(filePath);

            var fileStream = new MemoryStream(bytes);

            var saveFile = new SaveFile();
            saveFile.LoadPCSaveFile(fileStream);

            var prevNodeCount = saveFile.Nodes.Count;

            // Find johnny's glasses in the save.
            var item = saveFile.FlatNodes.FirstOrDefault(_ => _.Id == 349);
            Assert.That(item, Is.Not.Null);
            var itemData = (ItemData) item.Value;

            var genericData = itemData.Data;
            Assert.That(genericData, Is.AssignableTo(typeof(ItemData.ModableItemData)));
            var moddableItem = (ItemData.ModableItemData) genericData;

            // Remove the second mod.
            var children = moddableItem.RootNode.Children;
            moddableItem.RootNode.Children.RemoveAt(1);

            List<byte[]> newSave = new List<byte[]>(); // we need the array but cannot assign a variable inside the delegate
            Assert.DoesNotThrow(() => { newSave.Add(saveFile.SaveToPCSaveFile()); });
            saveFile = new SaveFile();
            using (var stream = new MemoryStream(newSave[0]))
            {
                Assert.DoesNotThrow(() => { saveFile.LoadPCSaveFile(stream); });
            }

            Assert.That(saveFile.Nodes.Count, Is.EqualTo(prevNodeCount));
        }
    }

    [TestFixtureSource(typeof(SaveFiles), "PS4SaveFileList")]
    class PS4ParserTests
    {
        private readonly string _filename;
        private readonly List<INodeParser> _parsers;
        public PS4ParserTests(string filename)
        {
            _filename = Utils.GetFullPathToFile(filename);
            _parsers = new List<INodeParser>();
            var interfaceType = typeof(INodeParser);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass);
            foreach (var type in types)
            {
                INodeParser instance = (INodeParser)Activator.CreateInstance(type);
                _parsers.Add(instance);
            }
        }

        [Test]
        public void ParsingNoThrowTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var newSaveFile = new SaveFile(_parsers);
            Assert.DoesNotThrow(() => { newSaveFile.LoadPS4SaveFile(new MemoryStream(bytes)); });
        }

        [Test]
        public void RewritingTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var newSaveFile = new SaveFile(_parsers);
            newSaveFile.LoadPS4SaveFile(new MemoryStream(bytes));
            var newBytes = newSaveFile.SaveToPS4SaveFile();

            Assert.That(newBytes.Length, Is.EqualTo(bytes.Length));
            Assert.That(newBytes.SequenceEqual(bytes), Is.True);
        }
    }
}
