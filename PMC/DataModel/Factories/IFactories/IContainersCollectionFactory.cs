using DataModel.Models;
using DataModel.Models.Positions;

namespace DataModel.Factories.IFactories
{
    public interface IContainersCollectionFactory<T> where T : struct
    {
        ContainersCollection<T> CreateWithEmptyContainers(int containersCount);
        ContainersCollection<T> CreateWithEmptyMatrices(int containersCount, int matricesCount, int positionsCount, params int[] pointsCount);
        ContainersCollection<T> CreateWithPositions(Position<T>[] positions);
    }
}
