using SOLID.OpenClosedPrinciple.Interfaces;

namespace SOLID.OpenClosedPrinciple.Specifications;

public class AndSpecification<T>(ISpecification<T> first, ISpecification<T> second) : ISpecification<T>
{
    private readonly ISpecification<T> _first = first
                                                ?? throw new ArgumentNullException(nameof(first));

    private readonly ISpecification<T> _second = second
                                                 ?? throw new ArgumentNullException(nameof(second));

    public bool IsSatisfied(T item) => _first.IsSatisfied(item) && _second.IsSatisfied(item);
}