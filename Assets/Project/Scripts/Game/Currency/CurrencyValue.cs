using System;

namespace Project.Scripts.Game.Currency
{
    [Serializable]
    public class CurrencyValue
    {
        public CurrencyType currencyType;
        public int amount;

        public CurrencyValue Clone()
        {
            return new CurrencyValue { currencyType = currencyType, amount = amount };
        }
    }
}