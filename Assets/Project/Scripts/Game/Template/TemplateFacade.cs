using System;
using Core.Unity;
using UnityEngine;

namespace AnlautJam.Game.Template
{
    public class TemplateFacade : AFacade
    {
        [SerializeField] private TemplateView templateView;
        
        public ITemplateView TemplateView => templateView;

        private void OnValidate()
        {
            Validate(ref templateView);
        }
    }
}