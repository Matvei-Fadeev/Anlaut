using DG.Tweening;
using Project.Scripts.Game.Currency;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Jam.Game.CurrencyHolder
{
    public class CurrencyValueView : MonoBehaviour
    {
        [SerializeField] private CurrencyIcons currencyIcons;
        [SerializeField] private Image currencyImage;
        [SerializeField] private TextMeshProUGUI currencyCountText;

        [Header("Animatoin")] [SerializeField] private float duration = 0.5f;

        private int _amount;

        public int Amount
        {
            get => _amount;
            private set
            {
                DOTween.To(() => _amount, x => _amount = x, value, duration).OnUpdate(() =>
                {
                    currencyCountText.text = _amount.ToString();
                    gameObject.SetActive(_amount > 0);
                });
            }
        }

        private CurrencyType _currencyType;

        public CurrencyType CurrencyType
        {
            get => _currencyType;
            private set
            {
                if (_currencyType == value) return;
                
                _currencyType = value;
                currencyImage.sprite = currencyIcons.GetIcon(_currencyType);
            }
        }

        public void UpdateCurrencyValue(CurrencyValue currencyValue)
        {
            CurrencyType = currencyValue.currencyType;
            Amount = currencyValue.amount;
        }
    }
}