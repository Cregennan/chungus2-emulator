using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct LimInstruction : IChungusInstruction<LimInstruction>
{
    /// <summary>
    /// Using <see cref="GeneralRegisterInfo.R0"/> does not store to any register, but uses intermediate as operands for the next instruction if <see cref="GeneralRegisterInfo.R0"/> is chosen.
    /// </summary>
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public byte Immediate { get; internal set; }
    
    public static LimInstruction FromBinary(ushort binary)
    {
        return new LimInstruction
        {
            Destination = (GeneralRegisterInfo)((binary >> 8) & 0b111),
            Immediate = (byte)binary
        };
    }
}