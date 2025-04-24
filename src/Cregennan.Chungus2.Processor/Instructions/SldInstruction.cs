using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct SldInstruction : IChungusInstruction<SldInstruction>
{
    public byte Destination { get; internal set; }
    
    public SpecialRegisterInfo Register { get; internal set; }
    
    public static SldInstruction FromBinary(ushort binary)
    {
        return new SldInstruction
        {
            Destination = (byte)((binary >> 8) & 0b111),
            Register = (SpecialRegisterInfo)(binary & 0b111)
        };
    }
}