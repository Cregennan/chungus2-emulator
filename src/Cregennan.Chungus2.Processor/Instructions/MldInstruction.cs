using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct MldInstruction : IChungusInstruction<MldInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    public byte Address { get; internal set; }
    
    public static MldInstruction FromBinary(ushort binary)
    {
        return new MldInstruction
        {
            Destination = (GeneralRegisterInfo)((binary >> 8) & 0b111),
            Address = (byte)binary
        };
    }
}