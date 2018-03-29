using Specification.Core;

namespace Specification.Specifications
{
    public class BoutiqueHotelSpesification : ISpecification<Hotel>
    {
        public bool IsSatisfiedBy(Hotel obj)
        {
            return obj.Boutique;
        }
    }
}