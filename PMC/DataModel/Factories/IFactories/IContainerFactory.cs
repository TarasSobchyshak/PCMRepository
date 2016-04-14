using DataModel.Models;

namespace DataModel.Factories.IFactories
{
    public interface IContainerFactory<T> where T : struct
    {
        Container<T> Create(int positionsCount, params int[][] pointsCount);
    }
}
