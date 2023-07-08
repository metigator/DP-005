namespace Metigator.BuilderDesignPattern.After;

// Builder (Construction Process
public class PropertyBuilder
{
    private Property _property = new();


    // SetAddress("aaa").SetPrice(100). [method chaining]
    public PropertyBuilder SetAddress(string address)
    {
        _property.Address = address;
        return this;
    }

    public PropertyBuilder WithTransactionType(TransactionType transactionType)
    {
        _property.TransactionType = transactionType;
        return this;
    }

    public PropertyBuilder WithPropertyType(PropertyType propertyType)
    {
        _property.PropertyType = propertyType;
        return this;
    }

    public PropertyBuilder SetTotalBedrooms(int totalBedrooms)
    {

        _property.TotalBedrooms = totalBedrooms;
        return this;
    }

    public PropertyBuilder SetFloorArea(double floorArea)
    {
        _property.FloorArea = floorArea;
        return this;
    }

    public PropertyBuilder SetPrice(decimal price)
    {
        _property.Price = price;
        return this;
    }

    public PropertyBuilder SetTotalBathrooms(int totalBathrooms)
    {
        _property.TotalBathrooms = totalBathrooms;
        return this;
    }

    public PropertyBuilder SetTotalStoreys(int totalStoreys)
    {
        _property.TotalStoreys = totalStoreys;
        return this;
    }

    public PropertyBuilder SetYearBuilt(int yearBuilt)
    {
        _property.YearBuilt = yearBuilt;
        return this;
    }

    public PropertyBuilder HasSwimmingPool(bool hasSwimmingPool)
    {
        _property.HasSwimmingPool = hasSwimmingPool;
        return this;
    }

    public PropertyBuilder HasWifi(bool hasWifi)
    {
        _property.HasWifi = hasWifi;
        return this;
    }

    public PropertyBuilder HasGym(bool hasGym)
    {
        _property.HasGym = hasGym;
        return this;
    }

    public PropertyBuilder HasParking(bool hasParking)
    {
        _property.HasParking = hasParking;
        return this;
    }

    public PropertyBuilder HasPlayground(bool hasPlayground)
    {
        _property.HasPlayground = hasPlayground;
        return this;
    }

    public PropertyBuilder Reset()
    {
        _property = new();
        return this;
    }

    private bool canBuild => !string.IsNullOrWhiteSpace(_property.Address) && _property.Price > 0;

    public Property Build()
    {
        if (!canBuild)
            throw new InvalidOperationException();
        var property = _property;
        this.Reset();
        return property;
    }
}
