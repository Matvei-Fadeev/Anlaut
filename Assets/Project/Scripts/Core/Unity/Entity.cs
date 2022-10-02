#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using Zenject;

namespace Core.Unity
{
    public class Entity : MonoInstaller
    {
        private DiContainer _externalContainer;

        private DiContainer DiContainer => _externalContainer ?? Container;

        public T Get<T>() where T : class
        {
            return DiContainer?.TryResolve<T>();
        }

        public override void InstallBindings()
        {
            InstallBindings(Container);
        }

        public virtual void InstallBindings(DiContainer diContainer)
        {
            _externalContainer = diContainer;
        }

        protected void Validate<T>(ref T component) where T : Component
        {
            if (!Equals(component, null))
                return;

            component = GetComponent<T>();
            component ??= GetComponentInChildren<T>(false);
            component ??= GetComponentInChildren<T>(true);
            component ??= GetComponentInParent<T>();

            if (!component.Equals(null))
            {
#if UNITY_EDITOR
                EditorUtility.SetDirty(this);
#endif
                return;
            }

            Debug.LogError($"Component of type {typeof(T)} not found in {name} or its children.");
        }
    }
}