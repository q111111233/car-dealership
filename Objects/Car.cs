using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<string> _cars = new List<string> {};

    public Car (string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public static List<string> GetAll()
    {
      return _cars;
    }
    public void Save()
    {
      _cars.Add("Car make: " + _makeModel + " Car Price: " + _price.ToString() + " Car Miles: " + _miles.ToString());
    }

    public static void ClearAll()
    {
      _cars.Clear();
    }
  }
}
