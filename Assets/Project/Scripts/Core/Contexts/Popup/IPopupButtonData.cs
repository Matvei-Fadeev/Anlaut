using UnityEngine;

namespace Project.Scripts.Core.Contexts.Popup
{
    public interface IPopupButtonData
    {
        Sprite Sprite { get; set; }
        string Text { get; set; }
    }
}