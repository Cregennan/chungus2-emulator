using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public class BitInstruction : IChungusInstruction<BitInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public GeneralRegisterInfo SourceA { get; internal set; }
    
    public GeneralRegisterInfo SourceB { get; internal set; }
    
    public BitwiseLogicInfo Type { get; internal set; }
    
    public static BitInstruction FromBinary(ushort word)
    {
        return new BitInstruction
        {
            Destination = word.ToRegisterByFirstByte(),
            SourceA = word.ToRegisterByStartingIndex(7),
            SourceB = word.ToRegisterByStartingIndex(2),
            Type = word.TwoBitsToEnum<BitwiseLogicInfo>(4)
        };
    }
}