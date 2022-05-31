using UnityEngine;
using Utils;
using Managers;

public class LoosedBallTrigger : MonoBehaviour {

    private IStateManager _stateManager;

    void Start() {
        _stateManager = ServiceLocator.Get<IStateManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<BallManager>()) {
            _stateManager.OnLoosedBall();
        }
    }
}
