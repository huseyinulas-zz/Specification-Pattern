using Specification.Core;

namespace Specification.Specifications
{
    public class EmptyRoomSpecification : ISpecification<Hotel>
    {
        private readonly int _roomCount;

        public EmptyRoomSpecification(int roomCount)
        {
            _roomCount = roomCount;
        }
        public bool IsSatisfiedBy(Hotel obj)
        {
            return obj.RoomCount - obj.BookedRoomCount >= _roomCount;
        }
    }
}