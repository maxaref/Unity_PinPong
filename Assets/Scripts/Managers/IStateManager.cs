using System;
using Utils;

namespace Managers {
    public interface IStateManager : IService {
        public void OnLoosedBall();
        public void Play();
        public event Action<State> OnStateChanged;
    }
}