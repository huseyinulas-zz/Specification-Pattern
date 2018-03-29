using Specification.Core;

namespace Specification.Specifications
{
    public class FiveStarSpesification : ISpecification<Hotel>
    {
        public bool IsSatisfiedBy(Hotel obj)
        {
            return obj.Star == 5;
        }
    }
}
