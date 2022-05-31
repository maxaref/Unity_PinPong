using UnityEngine;

public class BallSize : MonoBehaviour, IBallSize {
    [SerializeField] [Range(0.7f, 2f)] private float _scaleFrom;
    [SerializeField] [Range(0.7f, 2f)] private float _scaleTo;

    public void Reset() {
        float scale = Random.Range(_scaleFrom, _scaleTo);
        if (_scaleFrom > _scaleTo) scale = _scaleFrom;

        transform.localScale = Vector2.one * scale;
    }
}
