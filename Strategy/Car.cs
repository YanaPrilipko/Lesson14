// 4. Strategy -- https://www.dofactory.com/net/strategy-design-pattern
class Car
{
    protected int passengers; 
    protected string model; 

    public Car(int num, string model, IDrive ride)
    {
        this.passengers = num;
        this.model = model;
        Drive = ride;
    }
    public IDrive Drive { get; set; }
    public void Ride()
    {
        Drive.Ride();
    }
}