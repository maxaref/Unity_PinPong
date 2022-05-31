using UnityEngine;
using Utils;
using DataStorage;

namespace Managers {
    public class BallColorsManager : MonoBehaviour, IBallColorsManager {
        [SerializeField] private BallColors _ballColors;
        [SerializeField] private GameObject _colorsMenu;
        [SerializeField] private GameObject _paletteItem;
        [SerializeField] private GameObject _palettesParent;
        [SerializeField] private GameObject _ball;

        private IDataStorage _dataStorage;

        private void Awake() {
            ServiceLocator.Register<IBallColorsManager>(this);
        }

        private void Start() {
            _dataStorage = ServiceLocator.Get<IDataStorage>();

            InitColorsMenu();
            ApplyBallColor();
        }

        public void CloseMenu() {
            _colorsMenu.SetActive(false);
        }

        public void OpenMenu() {
            _colorsMenu.SetActive(true);
        }

        public void SetColor(Color color) {
            _dataStorage.BallColorId = _ballColors.GetColorId(color);
            ApplyBallColor();
        }

        private void ApplyBallColor() {
            Color color = _ballColors.GetColorById(_dataStorage.BallColorId);
            _ball.GetComponent<SpriteRenderer>().color = color;
        }

        private void InitColorsMenu() {
            foreach (Color color in _ballColors.GetColors()) {
                var item = CreatePalleteItem(color);
                item.transform.parent = _palettesParent.transform;
            }
        }

        private GameObject CreatePalleteItem(Color color) {
            var item = Instantiate(_paletteItem);
            item.GetComponent<IBallPaletteItem>().SetColor(color);
            return item;
        }
    }
}

