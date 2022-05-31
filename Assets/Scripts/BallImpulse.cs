using UnityEngine;
using Utils;

public class BallImpulse : MonoBehaviour, IBallImpulse {
    [SerializeField] [Range(5f, 10f)] private float _forceFrom;
    [SerializeField] [Range(5f, 10f)] private float _forceTo;

    private Rigidbody2D _rb;
    private IMathHelper _mathHelper;

    private void Awake() {
        _rb = GetComponent<Rigidbody2D>();
        _mathHelper = ServiceLocator.Get<IMathHelper>();
    }

    public void GiveRandomImpulse() {
        float force = Random.Range(_forceFrom, _forceTo);
        if (_forceFrom > _forceTo) force = _forceFrom;

        _rb.velocity = _mathHelper.GetRandomDirection() * force;
    }

    public void Stop() {
        _rb.velocity = Vector2.zero;
    }
}
