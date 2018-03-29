namespace Specification.Core
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _specification;

        public NotSpecification(ISpecification<T> specification)
        {
            _specification = specification;
        }

        public bool IsSatisfiedBy(T obj)
        {
            return !(_specification.IsSatisfiedBy(obj));
        }
    }
}