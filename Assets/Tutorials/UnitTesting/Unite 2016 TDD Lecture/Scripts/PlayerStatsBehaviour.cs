using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace PracticeProject.UnitTesting.TDDLecture 
{
    public class PlayerStatsBehaviour : MonoBehaviour
    {
        private PlayerStats _playerStats;
        public PlayerStats PlayerStats => _playerStats;

        [Space]
        [SerializeField] private TextMeshProUGUI _healthTMP;
        [SerializeField] private TextMeshProUGUI _currencyTMP;

        private void Awake()
        {
            _playerStats = new PlayerStats();
        }

        public void UpdateHealth(int deltaHealth)
        {
            _playerStats.UpdateHealth(deltaHealth);
            _healthTMP.text = PlayerStats.CurrentHealth.ToString();
        }

        public void UpdateCurrency(int deltaCurrency)
        {
            _playerStats.UpdateCurrency(deltaCurrency);
            _currencyTMP.text = PlayerStats.CurrentCurrency.ToString();
        }
    }
}
