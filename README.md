# Bech32

[![Nuget](https://img.shields.io/nuget/v/Nano.Bech32)](https://www.nuget.org/packages/Nano.Bech32/)

A small utility library to encode/decode bech32 addresses with source code taken from https://github.com/guillaumebonnot/bech32 to encode/decode Bech32 addresses.

This project exists only to be able to deploy a NuGet package to prevent endless copy & pasting of the excellent work 
of **Guillaume Bonnot** and **Palekhov Ilia**, who deserve full credits for their work.

## Using the library

To extract the **stake address** from a shelly address:

```csharp
var sampleAddress = "addr1qxde6dgn0qpq5xs60a4kwc3xdyw3r93rjj7z0m5u2807m6tcwrkjwym4hnjxlmy5syvqgqnd43xsd2d297l27l5unn4sdkq9xa";
var stakeAddress = StakeAddress.From(address);

Console.WriteLine(stakeAddress)
```

Output:

```
stake1u9u8pmf8zd6meer0aj2gzxqyqfk6cngx4x4zl04006wfe6czxzhdg
```