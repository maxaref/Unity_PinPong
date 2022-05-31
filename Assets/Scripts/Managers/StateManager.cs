using System;
using UnityEngine;
using Utils;

namespace Managers {
    public enum State {
        Playing,
        Menu
    }

    public class StateManager : MonoBehaviour, IStateManager {

        public event Action<State> OnStateChanged;

        private State _state = State.Menu;


        private void Awake() {
            ServiceLocator.Register<IStateManager>(this);
        }

        public void OnLoosedBall() {
            _state = State.Menu;
            OnStateChanged.Invoke(_state);
        }

        public void Play() {
            _state = State.Playing;
            OnStateChanged.Invoke(_state);
        }
    }
}