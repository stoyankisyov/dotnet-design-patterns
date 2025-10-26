using SOLID.OpenClosedPrinciple.Interfaces;

namespace SOLID.OpenClosedPrinciple.Specifications;

public class SizeSpecification(Size size) : ISpecification<Product>
{
    private Size _size = size;

    public bool IsSatisfied(Product item) => item.Size == _size;
}