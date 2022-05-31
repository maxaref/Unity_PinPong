using Utils;

namespace Managers {
    public interface IScoreManager : IService {
        public void OnCoughtBall();
        public void OnGameBegun();
    }
}

