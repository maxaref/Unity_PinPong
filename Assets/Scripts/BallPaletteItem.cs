using UnityEngine;
using UnityEngine.UI;
using Utils;
using Managers;
using UnityEngine.EventSystems;

public class BallPaletteItem : MonoBehaviour, IBallPaletteItem, IPointerDownHandler {
    private Color _color;

    private IBallColorsManager _colorsManager;

    private void Start() {
        _colorsManager = ServiceLocator.Get<IBallColorsManager>();
    }

    public void SetColor(Color color) {
        _color = color;
        GetComponent<Image>().color = color;
    }

    public void OnPointerDown(PointerEventData eventData) {
        _colorsManager.SetColor(_color);
        _colorsManager.CloseMenu();
    }
}
