using System;

namespace PracticeProject.UnitTesting.TDDLecture
{
    public class PlayerStats
    {
        private const int MAX_HEALTH = 100;
        public int CurrentHealth { get; set; }
        public int CurrentCurrency { get; set; }
        public PlayerStats()
        {
            CurrentHealth = MAX_HEALTH;
            CurrentCurrency = 0;
        }

        public void UpdateHealth(int deltaHelath)
        {
            int newHelath = CurrentHealth + deltaHelath;
            if(newHelath > MAX_HEALTH) 
            {
                CurrentHealth = MAX_HEALTH;
            }
            else if(newHelath < 0)
            {
                CurrentHealth = 0;
            }
            else
            {
                CurrentHealth = newHelath;
            }
        }

        public void UpdateCurrency(int deltaCurrency)
        {
            int newCurrency = CurrentCurrency + deltaCurrency;
            if (newCurrency < 0)
            {
                CurrentCurrency = 0;
            }
            else
            {
                CurrentCurrency = newCurrency;
            }
        }
    }
}