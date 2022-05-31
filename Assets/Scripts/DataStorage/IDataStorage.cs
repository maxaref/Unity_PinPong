using Utils;

namespace DataStorage {
    public interface IDataStorage : IService {
        public int BestScore { get; set; }
        public int BallColorId { get; set; }
    }
}
