using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct SfiInstruction : IChungusInstruction<SfiInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public byte Immediate { get; internal set; }
    
    public ShiftOperationInfo Type { get; internal set; }
    
    public static SfiInstruction FromBinary(ushort word)
    {
        return new SfiInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7),
            Immediate = (byte)(word & 0b111),
            Type = word.TwoBitsToEnum<ShiftOperationInfo>(4)
        };
    }
}