// 2. Decorator -- https://dofactory.com/net/decorator-design-pattern


class Program
{
    static void Main(string[] args)
    {

        Chocolate chocolate2 = new DarkChocolate();
        chocolate2 = new RaisinsChocolate(chocolate2);
        Console.WriteLine("Title: {0}", chocolate2.Name);
        Console.WriteLine("Price: {0}", chocolate2.GetCost());

        Chocolate chocolate3 = new DarkChocolate();
        chocolate3 = new NutsChocolate(chocolate3);
        chocolate3 = new RaisinsChocolate(chocolate3);
        Console.WriteLine("Title: {0}", chocolate3.Name);
        Console.WriteLine("Price: {0}", chocolate3.GetCost());
    }
}

abstract class Chocolate
{
    public Chocolate(string n)
    {
        Name = n;
    }
    public string Name { get; init; }
    public abstract int GetCost();
}


class DarkChocolate: Chocolate
{
    public DarkChocolate()
        : base("Dark Chocolate")
    {
    }
    public override int GetCost()
    {
        return 8;
    }
}

abstract class ChocolateDecorator : Chocolate
{
    protected Chocolate chocolate;
    public ChocolateDecorator(string n, Chocolate chocolate) : base(n)
    {
        chocolate = chocolate;
    }
}

class NutsChocolate : ChocolateDecorator
{
    public NutsChocolate(Chocolate p)
        : base(p.Name + " with nuts", p)
    {
    }

    public override int GetCost()
    {
        return chocolate.GetCost() + 3;
    }
}

class RaisinsChocolate : ChocolateDecorator
{
    public RaisinsChocolate(Chocolate p)
        : base(p.Name + "with raisins", p)
    {
    }
    public override int GetCost()
    {
        return chocolate.GetCost() + 5;
    }
}
