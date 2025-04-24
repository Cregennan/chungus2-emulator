using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct AdiInstruction : IChungusInstruction<AdiInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public sbyte Immediate { get; internal set; }
    
    public static AdiInstruction FromBinary(ushort word)
    {
        return new AdiInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7),
            Immediate = word.ToSignedExtension(5)
        };
    }
}