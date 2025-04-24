using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct AddInstruction : IChungusInstruction<AddInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public GeneralRegisterInfo SourceB { get; internal set; }
    
    public AluActionInfo Type { get; internal set; }
    
    public static AddInstruction FromBinary(ushort word)
    {
        return new AddInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7),
            SourceB = word.ToRegisterByStartingIndex(2),
            Type = word.TwoBitsToEnum<AluActionInfo>(4)
        };
    }
}