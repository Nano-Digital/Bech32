using Xunit;

namespace Nano.Bech32.UnitTests;

public class StakeAddressTest
{
    [Fact]
    public void TestValid()
    {
        var validAddress = "addr1qxde6dgn0qpq5xs60a4kwc3xdyw3r93rjj7z0m5u2807m6tcwrkjwym4hnjxlmy5syvqgqnd43xsd2d297l27l5unn4sdkq9xa";
        var expectedStakeAddress = "stake1u9u8pmf8zd6meer0aj2gzxqyqfk6cngx4x4zl04006wfe6czxzhdg";
        var actualStakeAddress = StakeAddress.From(validAddress);
        Assert.Equal(expectedStakeAddress, actualStakeAddress);
    }

    [Fact]
    public void TestInvalid()
    {
        var invalidAddress = "addr1qxde6dgn0qpq5xs60a4kwc3xdyw3r93rjj7z0m5u2807m6tcwrkjwym4hnjxlmy5syvqgqnd43xsd2d297l27l5unn4sdkq9xb";
        var actualStakeAddress = StakeAddress.From(invalidAddress);
        Assert.Null(actualStakeAddress);
    }
}