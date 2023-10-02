// 4. Strategy -- https://www.dofactory.com/net/strategy-design-pattern
class Program
{
    static void Main(string[] args)
    {
        Car auto = new Car(5, "W", new PetrolRide());
        auto.Ride();
        auto.Drive = new ElectricRide();
        auto.Ride();
    }
}
