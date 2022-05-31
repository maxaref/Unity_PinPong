using UnityEngine;
using Utils;

namespace Controls {

    public class RacketKeyboardInput : MonoBehaviour, IRacketInput {
        [SerializeField] private float _speedMultiplier = 1;

        private void Awake() {
#if UNITY_EDITOR
            ServiceLocator.Register<IRacketInput>(this);
#endif
        }

        public float GetMoveSpeed() {
            return Input.GetAxis("Vertical") * _speedMultiplier;
        }
    }
}
