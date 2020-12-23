using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core
{
    public class Constants
    {
        public static class SaveFile
        {
            public const string FIRST_FILE_HEADER_STRING = "VASC";
            public const string SECOND_FILE_HEADER_STRING = "FZLC";
        }
        public static class FileStructure
        {
            public const string OUTPUT_FOLDER_NAME = "Output";
            public const string UNCOMPRESSED_SUFFIX = "decompressed";
            public const string METAINFORMATION_SUFFIX = "metainf";
            public const string RECOMPRESSED_SUFFIX = "recompressed";
        }
        /// <summary>
        /// Constants for File Extensions. Does not include the dot)
        /// </summary>
        public static class FileExtensions
        {
            public const string JSON = "json";
            public const string DECOMPRESSED_FILE = "bin";
            public const string CYBERPUNK_SAVE_FILE = "dat";
        }
        public static class  Messages
        {
            public const string MISSING_FILE_TEXT = "File does not exist";
            public const string MISSING_METAINFO_FILE_TEXT = "Metainfo File not found";

        }
        public static class Parsing
        {
            public const string TPP_SECTION_NAME = "TPP";
        }
        public static class NodeNames
        {
            public const string GAME_SESSION_CONFIG_NODE = "game::SessionConfig";
            public const string CHARACTER_CUSTOMIZATION_APPEARANCES_NODE = "CharacetrCustomization_Appearances";
        }
    }
}
