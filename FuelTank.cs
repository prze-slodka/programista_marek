public class FuelTank : IVisitPort
{
    private Fuel _fuel;
    public double MaxCapacity { get; }
    
    public FuelTank(double capacity, Fuel fuel)
    {
        MaxCapacity = capacity;
        _fuel = fuel;
    }

    public double GetCapacity() => MaxCapacity;
    public string GetFuelType() => _fuel.GetType();
    
    public void VisitPort()
    {
        // Implement logic to adjust volume and weight
    }
}
