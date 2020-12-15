using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core
{
    public class Constants
    {
        public struct SaveFile
        {
            public const string FIRST_FILE_HEADER_STRING = "VASC";
            public const string SECOND_FILE_HEADER_STRING = "FZLC";
        }
        public struct FileStructure
        {
            public const string OUTPUT_FOLDER_NAME = "Output";
            public const string UNCOMPRESSED_SUFFIX = "uncompressed";
            public const string METAINFORMATION_SUFFIX = "metainf";
            public const string RECOMPRESSED_SUFFIX = "recompressed";
        }
    }
}
