using System;

namespace PracticeProject.UnitTesting
{
    public class DamageCalculator
    {
        public static int CalculateDamage(int damage, float mitigationPercent)
        {
            float multiplier = 1f - mitigationPercent;
            return Convert.ToInt32(damage * multiplier);
        }

        public static int CalculateDamage(int damage, ICharacter character)
        {
            int totalArmor = character.Inventory.GetTotalArmor() + (character.Level * 10);
            float multiplier = 100f - totalArmor;
            multiplier /= 100f;
            return Convert.ToInt32(damage * multiplier);
        }
    }
}
