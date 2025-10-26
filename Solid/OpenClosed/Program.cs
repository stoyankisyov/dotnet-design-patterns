using SOLID.OpenClosedPrinciple;
using SOLID.OpenClosedPrinciple.Filters;
using SOLID.OpenClosedPrinciple.Specifications;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);
var products = new List<Product> { apple, tree, house };

var productFilter = new ProductFilter();

Console.WriteLine("Green products:");
foreach (var p in productFilter.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($" - {p.Name} is green");
}

Console.WriteLine("Large products");
foreach (var p in productFilter.Filter(products, new SizeSpecification(Size.Large)))
{
    Console.WriteLine($" - {p.Name} is large");
}

Console.WriteLine("Large blue items");
foreach (var p in productFilter.Filter(products,
             new AndSpecification<Product>(
                 new ColorSpecification(Color.Blue),
                 new SizeSpecification(Size.Large))))
{
    Console.WriteLine($" - {p.Name} is big and blue");
}