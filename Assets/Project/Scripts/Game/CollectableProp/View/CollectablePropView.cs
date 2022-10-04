using DG.Tweening;
using UnityEngine;

namespace Jam.Game.CollectableProp
{
    public class CollectablePropView : MonoBehaviour, ICollectablePropView
    {
        [Header("Animations")]
        [SerializeField] private float duration;
        [SerializeField] private Ease ease;

        public void Show()
        {
            gameObject.transform.DOScale(1, duration).SetEase(ease);
        }

        public void Hide()
        {
            gameObject.transform.DOScale(0, duration).SetEase(ease);
        }
    }
}