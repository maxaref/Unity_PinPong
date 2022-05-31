using UnityEngine;

namespace Utils {
    public interface IMathHelper : IService {
        public Vector2 GetRandomDirection(float minAngle = 0, float maxAngle = 360);
    }
}

