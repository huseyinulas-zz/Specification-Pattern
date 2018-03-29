namespace Specification.Core
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T obj);
    }
}