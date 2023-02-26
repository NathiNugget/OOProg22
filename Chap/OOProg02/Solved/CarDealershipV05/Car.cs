﻿
/// <summary>
/// This class represents a car, for instance
/// a car sold in a car dealership
/// </summary>
public class Car
{
    #region Properties
    public string LicensePlate { get; }
    public string Brand { get; }
    public string Model { get; }
    public int Price { get; }
    #endregion

    #region Constructor
    public Car(string licensePlate, string brand, string model, int price)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Model = model;
        Price = price;
    }
    #endregion

    #region Overrides
    public override string ToString()
    {
        return LicensePlate + ": A " + Brand + " " + Model + ", price is " + Price;
    }

    public override bool Equals(object? obj)
    {
        return (obj != null && LicensePlate.Equals(((Car)obj).LicensePlate));
    }

    public static bool operator ==(Car c1, Car c2)
    {
        // If both are null, or both are same instance, return true.
        if (ReferenceEquals(c1, c2))
        {
            return true;
        }

        // If one is null, but not both, return false.
        if ((c1 is null) || (c2 is null))
        {
            return false;
        }

        // Return true if the fields match:
        return (c1.LicensePlate == c2.LicensePlate);
    }

    public static bool operator !=(Car c1, Car c2)
    {
        return !(c1 == c2);
    }

    public override int GetHashCode()
    {
        return LicensePlate?.GetHashCode() ?? 0;
    }
    #endregion
}
