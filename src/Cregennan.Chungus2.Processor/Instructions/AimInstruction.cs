using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct AimInstruction : IChungusInstruction<AimInstruction>
{
    public GeneralRegisterInfo Register { get; internal set; }
    
    public byte Immediate { get; internal set; }
    
    public static AimInstruction FromBinary(ushort binary)
    {
        return new AimInstruction
        {
            Register = (GeneralRegisterInfo)((binary >> 8) & 0b111),
            Immediate = (byte)binary
        };
    }
}