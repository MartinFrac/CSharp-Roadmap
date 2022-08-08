using Xunit;

namespace Tests;

public class TypesTest
{
  private Types _typesRepo;
  public TypesTest()
  {
    _typesRepo = new Types();
  }
  [Fact]
  public void ShouldReturnInfinity()
  {
    var expected = double.PositiveInfinity;
    var actual = _typesRepo.GetInfinity();
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void ShouldReturnNegativeInfinity()
  {
    var expected = double.NegativeInfinity;
    var actual = _typesRepo.GetInfinity();
    Assert.Equal(expected, actual);
  }
  
  [Fact]
  public void ShouldReturnMaxInteger()
  {
    var expected = int.MaxValue;
    var actual = _typesRepo.GetMaxInt();
    Assert.Equal(expected, actual);
  }
  
  [Fact]
  [Theory]
  [InlineData(null)]
  [InlineData(4)]
  [InlineData(null)]
  public void ShouldReturnTrueWhenValuePresent(int? value)
  {
    var expected = value.HasValue;
    var actual = _typesRepo.HasIntGotValue(value);
    Assert.Equal(expected, actual);
  }
}