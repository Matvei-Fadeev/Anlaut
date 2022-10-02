using Core.Unity;
using UnityEngine;
using Zenject;

namespace Jam.Game.Template
{
    public class TemplateEntity : Entity
    {
        [SerializeField] private TemplateView templateView;

        private void OnValidate()
        {
            Validate(ref templateView);
        }
        
        public override void InstallBindings(DiContainer diContainer)
        {
            base.InstallBindings(diContainer);
            TemplateInstaller.InstallBindings(diContainer, templateView);
        }
    }
}