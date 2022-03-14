using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApplicationLearn
{
   
    internal class WarcraftCalculationPreset : ICalculationPreset
    {
        public string PresetName { get => "Warcraft 3"; }

        public string[] AttackTypeData
        {
            get
            {
                return new string[] {
                    "Обычный",
                    "Проникающий",
                    "Осадный",
                    "Магический",
                    "Хаос-атака",
                    "Заклинание",
                    "Геройская атака",
                };
            }
        }

        public string[] ArmorTypeData
        {
            get
            {
                return new string[]
                {
                    "Легкий",
                    "Средний",
                    "Тяжелый",
                    "Здание",
                    "Геройская броня",
                    "Без брони",
                };
            }
        }
        public enum AttackTypeEnum
        {
            Default,
            Pierce,
            Siege,
            Magic,
            Chaos,
            Spell,
            HeroAttack,

            Max_AttackTypes
        }
        public enum ArmorTypeEnum
        {
            Light,
            Medium,
            Heavy,
            BuildingArmor,
            HeroArmor,
            NoArmor,

            Max_ArmorTypes,
        }

        public float[][] AttackArmorTable
        {
            get
            {
                return new float[][]
                {       
                    new float[] {1, 1.5f, 1,  0.7f, 1, 1,},
                    new float[] {2, 0.75f, 1, 0.35f, 0.5f, 1.5f },
                    new float[] {1, 0.5f, 1, 1.5f, 0.5f, 1.5f },
                    new float[] {1.25f, 0.75f, 2, 0.35f, 0.5f, 1 },
                    new float[] {1, 1, 1, 1, 1, 1, },
                    new float[] {1, 1, 1, 1, 0.7f, 1 },
                    new float[] {1, 1, 1, 0.5f, 1, 1 },
                };
            }
        }

        public float calculateDamage(in Attack attack, in Armor armor)
        {
            float damageMultiplier = AttackArmorTable[(int)attack.Type][(int)armor.Type];
            const float armorMultiplier = 0.06f;

            float damageReduction = 1 / (1 + armorMultiplier * armor.Value);
            float damage = damageReduction * attack.Value * damageMultiplier;

            return damage;
        }
    }
}
