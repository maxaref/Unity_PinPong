using UnityEngine;
using Utils;
using DataStorage;
using TMPro;

namespace Managers {
    public class ScoreManager : MonoBehaviour, IScoreManager {
        [SerializeField] private TextMeshProUGUI _levelScoreText;
        [SerializeField] private TextMeshProUGUI _bestScoreText;

        private int _levelScore = 0;
        private int _scorePerCatch = 1;

        private IDataStorage _dataStorage;

        private void Awake() {
            ServiceLocator.Register<IScoreManager>(this);
        }

        private void Start() {
            _dataStorage = ServiceLocator.Get<IDataStorage>();

            UpdateScoreText();
        }

        public void OnCoughtBall() {
            _levelScore += _scorePerCatch;

            if (_dataStorage.BestScore < _levelScore) {
                _dataStorage.BestScore = _levelScore;
            }

            UpdateScoreText();
        }

        private void UpdateScoreText() {
            _levelScoreText.text = _levelScore.ToString();
            _bestScoreText.text = _dataStorage.BestScore.ToString();
        }

        public void OnGameBegun() {
            _levelScore = 0;
            UpdateScoreText();
        }
    }
}

