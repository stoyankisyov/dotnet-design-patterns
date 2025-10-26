namespace SOLID.OpenClosedPrinciple.Interfaces;

public interface ISpecification<in T>
{
    bool IsSatisfied(T item);
}