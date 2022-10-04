using System;
using Project.Scripts.Game.Currency;

namespace Jam.Game.CollectableProp
{
    [Serializable]
    public class CollectablePropModel
    {
        public float collectingDelay;
        public float respawnDelay;
        public CurrencyValue currencyChangeOnPlayerInTrigger;
    }
}