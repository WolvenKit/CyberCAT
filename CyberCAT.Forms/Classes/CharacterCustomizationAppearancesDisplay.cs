using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CyberCAT.Core.Classes.NodeRepresentations.CharacterCustomizationAppearances;

namespace CyberCAT.Forms.Classes
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CharacterCustomizationAppearancesDisplay : CharacterCustomizationAppearances
    {
        [Editor(typeof(HexEditor), typeof(UITypeEditor))]
        public new byte[] UnknownFirstBytes { get=> _source.UnknownFirstBytes; set=> _source.UnknownFirstBytes = value; }
        [Editor(typeof(HexEditor), typeof(UITypeEditor))]
        public new byte[] TrailingBytes { get => _source.TrailingBytes; set => _source.TrailingBytes = value; }
        private CharacterCustomizationAppearances _source;
        public CharacterCustomizationAppearancesDisplay(CharacterCustomizationAppearances source)
        {
            _source = source;
            ThirdPerson = source.ThirdPerson;
            AdditionalThirdPerson = source.AdditionalThirdPerson;
            FirstPerson = source.FirstPerson;
        }
    }
}
