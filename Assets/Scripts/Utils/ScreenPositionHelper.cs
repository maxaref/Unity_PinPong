using UnityEngine;

namespace Utils {
    public class ScreenPositionHelper : MonoBehaviour, IScreenHelper {
        private float _left;
        private float _right;
        private float _top;
        private float _bottom;

        private void Awake() {
            ServiceLocator.Register<IScreenHelper>(this);

            Init();
        }

        private void Init() {
            var leftCenter = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
            var leftTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));

            _left = leftCenter.x;
            _right = -_left;
            _top = leftTop.y;
            _bottom = -leftTop.y;
        }

        private void SetX(Transform transform, float x) {
            var position = transform.position;
            position.x = x;
            transform.position = position;
        }

        public void MoveToLeftSide(Transform transform) {
            SetX(transform, _left + transform.localScale.x / 2);
        }

        public void MoveToRightSide(Transform transform) {
            SetX(transform, _right - transform.localScale.x / 2);
        }

        public float GetMaxY(Vector2 scale) {
            return _top - scale.y / 2;
        }

        public float GetMinY(Vector2 scale) {
            return _bottom + scale.y / 2;
        }
    }
}