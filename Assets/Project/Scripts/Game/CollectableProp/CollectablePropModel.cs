using System;
using Project.Scripts.Game.Currency;

namespace Jam.Game.CollectableProp
{
    [Serializable]
    public class CollectablePropModel
    {
        public CurrencyValue CurrencyChangeOnPlayerInTrigger;

        public CollectablePropModel()
        {
            CurrencyChangeOnPlayerInTrigger = new CurrencyValue
            {
                amount = 10,
                currencyType = CurrencyType.Gold
            };
        }
    }
}