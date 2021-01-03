using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.Interfaces;
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
            Assert.DoesNotThrow(() => { newSaveFile.LoadFromCompressedStream(new MemoryStream(bytes)); });
        }

        [Test]
        public void RewritingTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var newSaveFile = new SaveFile(_parsers);
            newSaveFile.LoadFromCompressedStream(new MemoryStream(bytes));
            var newBytes = newSaveFile.SaveToCompressed();

            Assert.That(newBytes.Length, Is.EqualTo(bytes.Length));
            //Assert.That(newBytes, Is.EquivalentTo(bytes));
            for (var i = 0; i < newBytes.Length; ++i) // Find a better way, this is slow...
            {
                Assert.That(newBytes[i], Is.EqualTo(bytes[i]));
            }
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
            Assert.DoesNotThrow(() => { newSaveFile.LoadFromUncompressedStream(new MemoryStream(bytes)); });
        }

        [Test]
        public void RewritingTest()
        {
            var bytes = File.ReadAllBytes(_filename);

            var newSaveFile = new SaveFile(_parsers);
            newSaveFile.LoadFromUncompressedStream(new MemoryStream(bytes));
            var newBytes = newSaveFile.SaveToUncompressed();

            Assert.That(newBytes.Length, Is.EqualTo(bytes.Length));
            //Assert.That(newBytes, Is.EquivalentTo(bytes));
            for (var i = 0; i < newBytes.Length; ++i) // Find a better way, this is slow...
            {
                Assert.That(newBytes[i], Is.EqualTo(bytes[i]));
            }
        }
    }
}
