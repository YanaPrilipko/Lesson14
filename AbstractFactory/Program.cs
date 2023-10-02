// 3. Abstract Factory -- https://dofactory.com/net/abstract-factory-design-pattern
class Program
{
    static void Main(string[] args)
    {
        Hero voin = new Hero(new VoinFactory());
        voin.Hit();
        voin.Run();
    }
}

abstract class Weapon
{
    public abstract void Hit();
}

abstract class Movement
{
    public abstract void Move();
}

class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Strike with the sword");
    }
}

class RunMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Run");
    }
}

abstract class HeroFactory
{
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}

class VoinFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new RunMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new Sword();
    }
}

class Hero
{
    private Weapon weapon;
    private Movement movement;
    public Hero(HeroFactory factory)
    {
        weapon = factory.CreateWeapon();
        movement = factory.CreateMovement();
    }
    public void Run()
    {
        movement.Move();
    }
    public void Hit()
    {
        weapon.Hit();
    }
}