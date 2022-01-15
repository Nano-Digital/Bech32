namespace Nano.Bech32;

public static class StakeAddress
{
    public static string? From(string address)
    {
        Bech32Encoder.Decode(address, out _, out var bech32);

        if (bech32 == null!)
            return null;

        var bech32Hex = Convert.ToHexString(bech32);
        var stakeHex = string.Concat("e1", bech32Hex.AsSpan(bech32Hex.Length - 56));
        var stakeBytes = Convert.FromHexString(stakeHex);
        return Bech32Encoder.Encode("stake", stakeBytes);
    }
}