using UnityEditor;
using UnityEngine;

namespace Core.Unity
{
    public abstract class AFacade : MonoBehaviour
    {
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
            }
        }
    }
}