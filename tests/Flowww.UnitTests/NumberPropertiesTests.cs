namespace Domain.UnitTests;

public class NumberPropertiesTests
{
    [Fact]
    public void Should_ReturnFalse_When_CheckingThat1IsPrime()
    {
        Assert.False(NumberProperties.IsPrime(1));
    }

    [Fact]
    public void Should_ReturnFalse_When_ChekingThatNegativeNumberIsPrime()
    {
        Assert.False(NumberProperties.IsPrime(-4));
    }

    [Fact]
    public void Should_ReturnTrue_When_ChekingThat2IsPrime()
    {
        Assert.True(NumberProperties.IsPrime(2));
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(20)]
    public void Should_ReturnFalse_When_CheckingThatEvenNumberIsPrime(int value)
    {
        Assert.False(NumberProperties.IsPrime(value));
    }

    [Theory]
    [InlineData(9)]
    [InlineData(15)]
    [InlineData(33)]
    public void Should_ReturnFalse_When_CheckingThatOddCompositeNumberIsPrime(int value)
    {
        Assert.False(NumberProperties.IsPrime(value));
    }

    [Theory]
    [InlineData(17)]
    [InlineData(3)]
    [InlineData(19)]
    public void Should_ReturnTrue_When_CheckingThatOddNonCompositeNumberIsPrime(int value)
    {
        Assert.True(NumberProperties.IsPrime(value));
    }
}