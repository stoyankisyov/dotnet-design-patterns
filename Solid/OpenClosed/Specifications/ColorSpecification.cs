using SOLID.OpenClosedPrinciple.Interfaces;

namespace SOLID.OpenClosedPrinciple.Specifications;

public class ColorSpecification(Color color) : ISpecification<Product>
{
    private Color _color = color;

    public bool IsSatisfied(Product p) => p.Color == _color;
}