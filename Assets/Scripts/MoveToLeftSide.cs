using UnityEngine;
using Utils;

public class MoveToLeftSide : MonoBehaviour {
    void Start() {
        ServiceLocator.Get<IScreenHelper>().MoveToLeftSide(transform);
    }
}
