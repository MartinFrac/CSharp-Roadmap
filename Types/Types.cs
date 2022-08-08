public class Types
{
  public void ShowRun()
  {
    var intMax = int.MaxValue;
    var intMin = int.MinValue;
    Console.WriteLine($"max value {intMax}");
    Console.WriteLine($"min value {intMin}");
    Console.WriteLine($"max value +1 {intMax + 1}");
    Console.WriteLine($"min value -1 {intMin - 1}");

    var decimalMax = decimal.MaxValue;
    Console.WriteLine($"decimal max: {decimalMax}");
    // Console.WriteLine($"decimal max + 1: {decimalMax+1}");

    int? intNullable = 5;
    System.Nullable<int> intNull = null;
    var hasValue = intNullable.HasValue;
    var hasValue2 = intNull.HasValue;
    Console.WriteLine($"has value: {hasValue}");
    Console.WriteLine($"has value: {hasValue2}");

    int intBox = 32;
    object box = intBox;
    Console.WriteLine($"box: {intBox}");
    if (box is int) Console.WriteLine("its an int");
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