using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPS.Models;

namespace UPS.Tests
{
  [TestClass]
  public class ParcelTests
  {
    // Test methods go here
    [TestMethod]
    public void ParcelConstructor_CreateInstanceOfParcel_Parcel()
    {      
      int[] dimensions = {5,5,5};
      Parcel package = new Parcel(dimensions, 10);
      Assert.AreEqual(typeof(Parcel), package.GetType());
    }

    [TestMethod]
    public void ParcelConstructor_AssignPropertyValuesToParcel_Parcel() 
    {
      int width = 10;
      int height = 10;
      int length = 10;
      int weight = 20;
      int[] dimensions = {width, height, length};
      Parcel package = new Parcel(dimensions, weight);
      Assert.AreEqual(dimensions, package.Dimensions);
      Assert.AreEqual(weight, package.Weight);
    }

    // * When you call a method called Volume() on a Parcel instance, it should return the product of the sides.
    [TestMethod]
    public void Volume_MultiplyDimensionsOfParcel_IntVolume()
    {
      //Arrange
      int[] dimensions = {5, 5, 4};
      int weight = 20;
      //Act
      Parcel package = new Parcel(dimensions, weight);
      //Assert
      Assert.AreEqual(100, package.Volume());
    }

    // * When you call a CostToShip() method on your parcel, return a cost based on a formula you make up. $1.36 per lb
    [TestMethod]
    public void CostToShip_CalculatesCostOfShippingBasedOnWeight_DoubleCost()
    {
      //Arrange
      int[] dimensions = {5, 5, 4};
      int weight = 21;
      //Act
      Parcel package = new Parcel(dimensions, weight);
      //Assert
      Assert.AreEqual(28.56, package.CostToShip());
    }

  }
}