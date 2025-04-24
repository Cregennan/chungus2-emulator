using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct JmpInstruction : IChungusInstruction<JmpInstruction>
{
    public short Location { get; internal set; }
    
    public static JmpInstruction FromBinary(ushort binary)
    {
        return new JmpInstruction
        {
            Location = (short)(binary & 0b111_11111111)
        };
    }
}