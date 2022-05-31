using UnityEngine;

namespace Utils {
    public interface IScreenHelper : IService {
        public float GetMaxY(Vector2 scale);
        public float GetMinY(Vector2 scale);
        public void MoveToLeftSide(Transform transform);
        public void MoveToRightSide(Transform transform);
    }
}