using UnityEngine;
using Utils;

namespace Managers {
    public class UIManager : MonoBehaviour, IUIManager {
        [SerializeField] private GameObject _gameUI;
        [SerializeField] private GameObject _menuUI;

        private IStateManager _stateManager;

        private void Awake() {
            ServiceLocator.Register<IUIManager>(this);
        }

        private void Start() {
            _stateManager = ServiceLocator.Get<IStateManager>();
            _stateManager.OnStateChanged += OnStateChanged;

            ShowMenuUI();
        }

        private void OnDestroy() {
            _stateManager.OnStateChanged -= OnStateChanged;
        }

        private void OnStateChanged(State state) {
            if (state == State.Playing) {
                ShowGameUI();
            }
            else {
                ShowMenuUI();
            }
        }

        public void ShowGameUI() {
            _gameUI.SetActive(true);
            _menuUI.SetActive(false);
        }

        public void ShowMenuUI() {
            _gameUI.SetActive(false);
            _menuUI.SetActive(true);
        }
    }
}