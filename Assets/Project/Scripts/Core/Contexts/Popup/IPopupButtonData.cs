using UnityEngine;

namespace Core.Contexts.Popup
{
    public interface IPopupButtonData
    {
        Sprite Sprite { get; set; }
        string Text { get; set; }
    }
}