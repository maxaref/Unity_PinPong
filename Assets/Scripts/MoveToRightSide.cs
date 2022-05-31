using UnityEngine;
using Utils;

public class MoveToRightSide : MonoBehaviour {
    void Start() {
        ServiceLocator.Get<IScreenHelper>().MoveToRightSide(transform);
    }
}
