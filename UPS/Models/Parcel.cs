using System;

namespace UPS.Models
{
  public class Parcel
  {
    public int[] Dimensions {get; set;}
    public int Weight {get; set;}

    public Parcel(int[] dimensions, int weight) 
    { 
      Dimensions = dimensions;
      Weight = weight;
    }

    public int Volume()
    {
      int volume = Dimensions[0] * Dimensions[1] * Dimensions[2];
      return volume;
    }

    public double CostToShip()
    {
      double cost = 1.36 * Weight;
      return Math.Round(cost, 2);
    }
  }
}