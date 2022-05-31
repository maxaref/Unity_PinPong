using UnityEngine;

namespace Controls {
    public class RacketSwipeInput : MonoBehaviour, IRacketInput {
        [SerializeField] private float _minSwipeOffset = 0.005f;
        [SerializeField] private float _offsetMultiplier = 1;

        private Vector2 _lastPosition;
        private float _swipeVerticalOffset;

        private void Awake() {
#if !UNITY_EDITOR
        ServiceLocator.Register<IRacketInput>(this);
#endif
        }

        void Update() {
            HandleSwipe();
        }

        private void HandleSwipe() {
            _swipeVerticalOffset = 0;

            if (Input.touchCount == 1) {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began) {
                    _lastPosition = touch.position;
                    return;
                }

                if (_lastPosition.Equals(Vector3.zero)) {
                    return;
                }

                var offset = (touch.position.y - _lastPosition.y) / Screen.height;

                if (Mathf.Abs(offset) > _minSwipeOffset) {
                    _swipeVerticalOffset = offset;
                    _lastPosition = touch.position;
                }
            }
            else {
                _lastPosition = Vector3.zero;
            }
        }

        public float GetMoveSpeed() {
            return _swipeVerticalOffset * _offsetMultiplier;
        }
    }
}