using UnityEngine;

namespace Utils {
    [CreateAndRegisterService(typeof(IMathHelper))]
    public class MathHelper : IMathHelper {
        public Vector2 GetRandomDirection(float minAngle = 0, float maxAngle = 360) {
            float angle = (Random.value * maxAngle + minAngle) * Mathf.Deg2Rad;
            return new Vector2(Mathf.Cos(angle), Mathf.Sign(angle));
        }
    }
}

