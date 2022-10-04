using System.Collections.Generic;
using System.Linq;
using Project.Scripts.Game.Currency;
using UnityEngine;

namespace Jam.Game.CurrencyHolder
{
    public class CurrencyHolderView : MonoBehaviour, ICurrencyHolderView
    {
        [SerializeField] private CurrencyValueView currencyValueViewPrefab;
        [SerializeField] private Transform spawnParent;
        [SerializeField] private List<CurrencyValueView> currencyValueViews;

        public void UpdateCurrency(CurrencyValue currencyValue)
        {
            var currencyValueView = currencyValueViews.FirstOrDefault(x => x.CurrencyType == currencyValue.currencyType);
            if (currencyValueView == null)
            {
                currencyValueView = Instantiate(currencyValueViewPrefab, spawnParent);
                currencyValueViews.Add(currencyValueView);
            }
            
            currencyValueView.UpdateCurrencyValue(currencyValue);
        }
    }
}