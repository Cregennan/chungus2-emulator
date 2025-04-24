using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct CalInstruction : IChungusInstruction<CalInstruction>
{
    public short Location { get; internal set; }
    
    public static CalInstruction FromBinary(ushort binary)
    {
        return new CalInstruction
        {
            Location = (short)(binary & 0b111_11111111)
        };
    }
}