using UnityEngine;
using Utils;

namespace Managers {
    public interface IBallColorsManager : IService {
        public void OpenMenu();
        public void CloseMenu();
        public void SetColor(Color color);
    }
}
