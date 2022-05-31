using UnityEngine;
using Utils;
using Controls;

public class RacketMovement : MonoBehaviour {
    private IRacketInput _racketInput;
    private IScreenHelper _screenHelper;

    private float _minY;
    private float _maxY;

    void Start() {
        _racketInput = ServiceLocator.Get<IRacketInput>();
        _screenHelper = ServiceLocator.Get<IScreenHelper>();

        _minY = _screenHelper.GetMinY(transform.localScale);
        _maxY = _screenHelper.GetMaxY(transform.localScale);
    }

    void Update() {
        HandleVerticalMovement();
    }

    private void HandleVerticalMovement() {
        float y = Mathf.Clamp(
            transform.position.y + _racketInput.GetMoveSpeed(),
            _minY,
            _maxY
        );

        var position = transform.position;
        position.y = y;
        transform.position = position;
    }
}
