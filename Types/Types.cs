public class Types
{
  public void ShowRun()
  {
    //overflow
    //overflow decimal

    int? intNullable = 5;
    System.Nullable<int> intNull = null;

    int intBox = 32;
    object box = intBox;
    Console.WriteLine($"box: {intBox}");
    if (box is int) Console.WriteLine("its an int");
  }
  
  public bool? HasIntGotValue(int? nullableInt)
  {
    return null;
  }

  public double? GetInfinity()
  {
    return null;
  }

  public double? GetNegativeInfinity()
  {
    return null;
  }

  public int? GetMaxInt()
  {
    return null;
  }
}