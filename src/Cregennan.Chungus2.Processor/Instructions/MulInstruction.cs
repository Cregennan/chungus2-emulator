using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct MulInstruction : IChungusInstruction<MulInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public GeneralRegisterInfo SourceB { get; internal set; }
    
    public MultiplyVariantsInfo Type { get; internal set; }
    
    public static MulInstruction FromBinary(ushort word)
    {
        return new MulInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7),
            SourceB = word.ToRegisterByStartingIndex(2),
            Type = word.TwoBitsToEnum<MultiplyVariantsInfo>(4)
        };
    }
}