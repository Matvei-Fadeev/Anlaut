using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Project.Scripts.Game.Currency
{
    [CreateAssetMenu(fileName = "CurrencyIcons", menuName = "Configs/UI/CurrencyIcons")]
    public class CurrencyIcons : ScriptableObject
    {
        [Serializable]
        private class CurrencyIcon
        {
            public Sprite icon;
            public CurrencyType type;
        }

        [SerializeField] private Sprite defaultIcon;
        [SerializeField] private List<CurrencyIcon> currencyIcons;

        public Sprite GetIcon(CurrencyType type)
        {
            var currencyIcon = currencyIcons.FirstOrDefault(x => x.type == type);
            if (currencyIcon == null)
                return defaultIcon;

            return currencyIcon.icon;
        }
    }
}