using System;
using System.IO;
using CyberCAT.Core;
using CyberCAT.Core.Classes;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CyberCAT.Tests
{
    [TestFixture("saves\\sav1.dat")]
    [TestFixture("saves\\sav2.dat")]
    public class SaveFileCompressionTests
    {
        private readonly string _saveFile;
        private string _jsonPath;
        private string _binPath;
        private string _recompressedBinPath;

        public SaveFileCompressionTests(string saveFile)
        {
            _saveFile = Utils.GetFullPathToFile(saveFile);
        }

        [SetUp]
        public void Setup()
        {
            if (!Directory.Exists(Constants.FileStructure.OUTPUT_FOLDER_NAME))
            {
                Directory.CreateDirectory(Constants.FileStructure.OUTPUT_FOLDER_NAME);
            }
        }

        [Test, Order(1)]
        public void Can_decompress_file()
        {
            using (var compressedInputStream = File.OpenRead(_saveFile))
            {
                var activeSaveFile = new SaveFileCompressionHelper();
                var decompressedFile = activeSaveFile.Decompress(compressedInputStream);
                var json = JsonConvert.SerializeObject(activeSaveFile.MetaInformation, Formatting.Indented);

                _jsonPath = $"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{activeSaveFile.MetaInformation.FileGuid}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}";
                File.WriteAllText(_jsonPath, json);

                _binPath = $"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{activeSaveFile.MetaInformation.FileGuid}_{Constants.FileStructure.UNCOMPRESSED_SUFFIX}.{Constants.FileExtensions.DECOMPRESSED_FILE}";
                File.WriteAllBytes(_binPath, decompressedFile);
            }
        }
        
        [Test, Order(2)]
        public void Can_recompress_file()
        {
            var activeSaveFile = new SaveFileCompressionHelper();
            var recompressedFilePath = $"{Constants.FileStructure.OUTPUT_FOLDER_NAME}";
            activeSaveFile.CompressFromSingleFile(_binPath, _jsonPath, recompressedFilePath);
            _recompressedBinPath = Path.Combine(recompressedFilePath, $"{activeSaveFile.MetaInformation.FileGuid}_{Constants.FileStructure.RECOMPRESSED_SUFFIX}.bin"); ;
        }
        /// <summary>
        /// Not that it could be possible that this fails due to slight differences in compression setting but still be a valid file
        /// </summary>
        [Test, Order(3)]
        public void Is_recompressed_equal_to_original()
        {
            Assert.IsTrue(FileCompare(_saveFile, _recompressedBinPath));
        }

        private bool FileCompare(string file1, string file2)
        {
            using (var fs1 = new FileStream(file1, FileMode.Open))
            using (var fs2 = new FileStream(file2, FileMode.Open))
            {
                if (fs1.Length != fs2.Length)
                {
                    throw new ParserException($"File lengths are not equal. {fs1.Length} vs {fs2.Length}");
                }

                int file1byte;
                int file2byte;

                do
                {
                    file1byte = fs1.ReadByte();
                    file2byte = fs2.ReadByte();
                }
                while (file1byte == file2byte && file1byte != -1);

                var isEqual = file1byte - file2byte == 0;

                if (!isEqual)
                {
                    throw new ParserException($"Files are not equal at {fs1.Position}");
                }

                return true;
            }
        }
    }

    public class ParserException : Exception
    {
        public ParserException(string message) : base(message) { }
    }
}
