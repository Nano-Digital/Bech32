using Xunit;

namespace Nano.Bech32.UnitTests;

public class Bech32Test
{
    [Fact]
    public void TestValid()
    {
        string[] validChecksum =
        {
            "A12UEL5L",
            "an83characterlonghumanreadablepartthatcontainsthenumber1andtheexcludedcharactersbio1tt5tgs",
            "abcdef1qpzry9x8gf2tvdw0s3jn54khce6mua7lmqqqxw",
            "11qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqc8247j",
            "split1checkupstagehandshakeupstreamerranterredcaperred2y9e3w",
        };

        foreach (var encoded in validChecksum)
        {
            Bech32Encoder.Decode(encoded, out var hrp, out var data);
            Assert.NotNull(data);

            var rebuild = Bech32Encoder.Encode(hrp!, data!);
            Assert.NotNull(rebuild);
            Assert.Equal(encoded.ToLower(), rebuild);
        }
    }

    [Fact]
    public void TestInvalid()
    {
        string[] invalidChecksum =
        {
            "tc1qw508d6qejxtdg4y5r3zarvary0c5xw7kg3g4ty",
            "bc1qw508d6qejxtdg4y5r3zarvary0c5xw7kv8f3t5",
            "BC13W508D6QEJXTDG4Y5R3ZARVARY0C5XW7KN40WF2",
            "bc1rw5uspcuh",
            "bc10w508d6qejxtdg4y5r3zarvary0c5xw7kw508d6qejxtdg4y5r3zarvary0c5xw7kw5rljs90",
            "BC1QR508D6QEJXTDG4Y5R3ZARVARYV98GJ9P",
            "tb1qrp33g0q5c5txsp9arysrx4k6zdkfs4nce4xj0gdcccefvpysxf3q0sL5k7",
        };

        foreach (var encoded in invalidChecksum)
        {
            Bech32Encoder.Decode(encoded, out _, out var data);
            Assert.Null(data);
        }
    }
}