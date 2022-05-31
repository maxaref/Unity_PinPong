using UnityEngine;
using Utils;

namespace Managers {
    public class BallManager : MonoBehaviour {

        private IStateManager _stateManager;
        private IBallImpulse _impulse;
        private IBallSize _size;

        private Vector2 _initialPosition;

        void Start() {
            _impulse = GetComponent<IBallImpulse>();
            _size = GetComponent<IBallSize>();
            _stateManager = ServiceLocator.Get<IStateManager>();

            _stateManager.OnStateChanged += OnStateChanged;

            _initialPosition = transform.position;
        }

        private void OnDestroy() {
            _stateManager.OnStateChanged -= OnStateChanged;
        }

        private void OnStateChanged(State state) {
            switch (state) {
                case State.Playing:
                    transform.position = _initialPosition;
                    _size.Reset();
                    _impulse.GiveRandomImpulse();
                    break;

                case State.Menu:
                    break;
            }

        }
    }
}

