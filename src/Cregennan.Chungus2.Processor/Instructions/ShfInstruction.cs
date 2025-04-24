using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct ShfInstruction : IChungusInstruction<ShfInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public GeneralRegisterInfo SourceB { get; internal set; }
    
    public ShiftOperationInfo Type { get; internal set; }
    
    public static ShfInstruction FromBinary(ushort word)
    {
        return new ShfInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7),
            SourceB = word.ToRegisterByStartingIndex(2),
            Type = word.TwoBitsToEnum<ShiftOperationInfo>(4)
        };
    }
}