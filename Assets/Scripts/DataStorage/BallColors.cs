using System;
using UnityEngine;

namespace DataStorage {
    [CreateAssetMenu(fileName = "BallColors", menuName = "ScriptableObjects/BallColors")]
    public class BallColors : ScriptableObject {
        [SerializeField] private Color[] _colors;

        public Color GetColorById(int id) {
            if (id < 0 || id >= _colors.Length) throw new Exception("Wrong color id");

            return _colors[id];
        }

        public int GetColorId(Color color) {
            return Array.IndexOf(_colors, color);
        }

        public Color[] GetColors() {
            return _colors;
        }
    }
}


