using UnityEngine;
using Managers;
using Utils;

public class RacketHitBallHandler : MonoBehaviour {

    private IScoreManager _scoreManager;

    void Start() {
        _scoreManager = ServiceLocator.Get<IScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.GetComponent<BallManager>()) {
            _scoreManager.OnCoughtBall();
        }
    }
}
