﻿using System.Collections.Generic;

namespace Project.Scripts.Core.Contexts.Popup
{
    public interface IPopupConfig
    {
        string Title { get; set; }
        string Description { get; set; }
        List<IPopupButtonData> ButtonData { get; set; }
    }
}