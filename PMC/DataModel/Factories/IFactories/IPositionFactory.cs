using DataModel.Models.Positions;

namespace DataModel.Factories.IFactories
{
    public interface IPositionFactory<T> where T : struct
    {
        PositionX<T> CreatePositionX(int pointsCount);
        PositionXY<T> CreatePositionXY(int pointsCount);
        PositionXYZ<T> CreatePositionXYZ(int pointsCount);
    }
}
