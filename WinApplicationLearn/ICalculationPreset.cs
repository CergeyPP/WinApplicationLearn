using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApplicationLearn
{
    internal interface ICalculationPreset
    {
        public string PresetName { get; }

        public string[] AttackTypeData { get; }
        public string[] ArmorTypeData { get; }
        public float[][] AttackArmorTable { get; }

        public float calculateDamage(in Attack attack, in Armor armor);
    }
}
