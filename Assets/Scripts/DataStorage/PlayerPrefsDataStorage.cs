using UnityEngine;
using Utils;

namespace DataStorage {
    [CreateAndRegisterService(typeof(IDataStorage))]
    public class PlayerPrefsDataStorage : IDataStorage {
        private const string BEST_SCORE_KEY = "BEST_SCORE";
        private const string BALL_COLOR_ID_KEY = "BALL_COLOR_ID";

        public int BestScore {
            get {
                return PlayerPrefs.GetInt(BEST_SCORE_KEY);
            }
            set {
                PlayerPrefs.SetInt(BEST_SCORE_KEY, value);
            }
        }

        public int BallColorId {
            get {
                return PlayerPrefs.GetInt(BALL_COLOR_ID_KEY);
            }
            set {
                PlayerPrefs.SetInt(BALL_COLOR_ID_KEY, value);
            }
        }
    }
}
