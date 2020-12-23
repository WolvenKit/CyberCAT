using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CyberCAT.Core.Classes.NodeRepresentations.CharacterCustomizationAppearances;

namespace CyberCAT.Forms.Classes
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CharacterCustomizationAppearancesDisplay : CharacterCustomizationAppearances
    {
        public CharacterCustomizationAppearancesDisplay(CharacterCustomizationAppearances source)
        {
            UnknownFirstBytes = source.UnknownFirstBytes;
            ThirdPerson = source.ThirdPerson;
            AdditionalThirdPerson = source.AdditionalThirdPerson;
            FirstPerson = source.FirstPerson;
            TrailingBytes = source.TrailingBytes;
        }
    }
}
