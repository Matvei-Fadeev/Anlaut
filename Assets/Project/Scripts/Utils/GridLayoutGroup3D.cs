using UnityEngine;

namespace Project.Editor
{
    public class GridLayoutGroup3D : MonoBehaviour
    {
        [SerializeField] private int weight;
        [SerializeField] private Vector2 offset;

        [ContextMenu(nameof(AlignPositions))]
        private void AlignPositions()
        {
            var transformRoot = transform;
            var childesCount = transformRoot.childCount;
            var index = 0;
            var startPosition = transformRoot.position;
            while (index < childesCount)
            {
                var child = transformRoot.GetChild(index);
                var column = index % weight;
                var row = index / weight;
                child.position = new Vector3(startPosition.x + offset.x * column 
                    , startPosition.y
                    , startPosition.z + offset.y * row);

                index++;
            }
        }
    }
}