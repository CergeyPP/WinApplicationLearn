using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApplicationLearn
{
    internal class DotaCalculatorPreset : ICalculationPreset
    {
        public string PresetName { get => "Dota 2"; }

        public string[] AttackTypeData
        {
            get
            {
                return new string[] {
                    "Герой",
                    "Малое создание",
                    "Проникающая атака",
                    "Осадная единица",
                };
            }
        }

        public string[] ArmorTypeData
        {
            get
            {
                return new string[]
                {
                    "Герой",
                    "Малое создание",
                    "Проникающая атака",
                    "Осадная единица",
                };
            }
        }


        public float[][] AttackArmorTable
        {
            get
            {
                return new float[][]
                {
                    new float[] {1, 1, 1, 0.5f},
                    new float[] {0.75f, 1, 1, 0.7f},
                    new float[] {0.5f, 1.5f, 1.5f, 0.7f},
                    new float[] {1, 1, 1, 1.5f},
                };
            }
        }

        public float calculateDamage(in Attack attack, in Armor armor)
        {
            float damageMultiplier = AttackArmorTable[attack.Type][armor.Type];
            const float armorFactor = 0.06f;

            float damageReduction = 1 - (armorFactor * armor.Value / (1 + armorFactor * armor.Value));
            float damage = damageReduction * attack.Value * damageMultiplier;

            return damage;
        }
    }
}
