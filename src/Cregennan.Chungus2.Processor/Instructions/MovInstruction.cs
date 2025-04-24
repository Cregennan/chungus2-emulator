using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct MovInstruction : IChungusInstruction<MovInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public static MovInstruction FromBinary(ushort word)
    {
        return new MovInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7)
        };
    }
}