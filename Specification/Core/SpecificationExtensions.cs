namespace Specification.Core
{
    public static class SpecificationExtensions
    {
        public static ISpecification<TEntity> And<TEntity>(this ISpecification<TEntity> leftSpecification, ISpecification<TEntity> rightSpecification)
        {
            return new AndSpecification<TEntity>(leftSpecification, rightSpecification);
        }

        public static ISpecification<TEntity> Or<TEntity>(this ISpecification<TEntity> specificationOne, ISpecification<TEntity> specificationTwo)
        {
            return new OrSpecification<TEntity>(specificationOne, specificationTwo);
        }

        public static ISpecification<TEntity> Not<TEntity>(this ISpecification<TEntity> specification)
        {
            return new NotSpecification<TEntity>(specification);
        }
    }
}