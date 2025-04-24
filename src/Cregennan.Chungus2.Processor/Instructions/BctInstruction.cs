using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct BctInstruction : IChungusInstruction<BctInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public byte Immediate { get; internal set; }
    
    public BitCountActionInfo Type { get; internal set; }
    
    public static BctInstruction FromBinary(ushort word)
    {
        return new BctInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7),
            Immediate = (byte)(word & 0b111),
            Type = word.TwoBitsToEnum<BitCountActionInfo>(4)
        };
    }
}