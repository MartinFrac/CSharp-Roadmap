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
}