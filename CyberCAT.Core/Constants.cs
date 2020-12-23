using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core
{
    public class Constants
    {
        public static class Magic
        {
            public const string FIRST_FILE_HEADER_MAGIC = "VASC";
            public const string SECOND_FILE_HEADER_MAGIC = "FZLC";
            public const string LZ4_CHUNK_MAGIC = "4ZLX";
            public const string NODE_INFORMATION_START = "EDON";
            public const string END_OF_FILE = "ENOD";
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
            public const string FPP_SECTION_NAME = "FPP";
        }
        public static class NodeNames
        {
            public const string GAME_SESSION_CONFIG_NODE = "game::SessionConfig";
            public const string ITEM_DATA = "itemData";
            public const string CHARACTER_CUSTOMIZATION_APPEARANCES_NODE = "CharacetrCustomization_Appearances";
        }
        public static class Numbers
        {
            public const int DEFAULT_HEADER_SIZE = 3105;
        }
    }
}
