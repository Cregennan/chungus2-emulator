using Cregennan.Chungus2.Processor.Enums;

namespace Cregennan.Chungus2.Processor.Extensions;

public static class BitExtensions
{
    public static GeneralRegisterInfo ToRegisterByFirstByte(this ushort binary) => (GeneralRegisterInfo)((binary >> 8) & 0b111);

    /// <summary>
    /// Converts 3 bits from specified index (counting from right, LSB) to <see cref="GeneralRegisterInfo"/>
    /// </summary>
    public static GeneralRegisterInfo ToRegisterByStartingIndex(this ushort binary, int startIndex)
    {
        var mask = 0b111 << (startIndex - 2); // minus 2 because we are counting from zero
        var target = (binary & mask) >> (startIndex - 2);
        return (GeneralRegisterInfo)target;
    }
    

    /// <summary>
    /// Converts two's complement last <see cref="numberOfBits"/> bits (LSB side) to sbyte
    /// </summary>
    public static sbyte ToSignedExtension(this ushort bits, int numberOfBits)
    {
        var isNegative = (bits & (1 << numberOfBits)) != 0;
        var signMask = (1 << numberOfBits) - 1;
        var withoutSign = signMask & bits;

        return (sbyte)(isNegative ? withoutSign : -((withoutSign ^ signMask) + 1));
    }

    public static T TwoBitsToEnum<T>(this ushort word, int startIndex) where T: Enum
    {
        var mask = 0b11 << (startIndex - 1); // minus 1 because we are counting from zero
        var target = (word & mask) >> (startIndex - 1);
        return (T)Enum.ToObject(typeof(T), target);
    }
}