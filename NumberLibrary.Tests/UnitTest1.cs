using Xunit;


public class NumberOperationsTests
{
    private readonly NumberOperations _numberOperations = new NumberOperations();

    [Fact]
    public void Round_ValidDouble_ReturnsRoundedValue()
    {
        var result = _numberOperations.Round(2.5);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Absolute_NegativeNumber_ReturnsPositiveValue()
    {
        var result = _numberOperations.Absolute(-5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        var result = _numberOperations.IsEven(4);
        Assert.True(result);
    }

    [Fact]
    public void IsOdd_OddNumber_ReturnsTrue()
    {
        var result = _numberOperations.IsOdd(3);
        Assert.True(result);
    }

    [Fact]
    public void Round_InvalidDouble_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _numberOperations.Round(double.NaN));
    }
}
