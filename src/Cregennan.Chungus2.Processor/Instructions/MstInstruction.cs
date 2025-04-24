using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct MstInstruction : IChungusInstruction<MstInstruction>
{
    public GeneralRegisterInfo Source { get; internal set; }
    
    public byte Address { get; internal set; }
    
    public static MstInstruction FromBinary(ushort binary)
    {
        return new MstInstruction
        {
            Source = (GeneralRegisterInfo)((binary >> 8) & 0b111),
            Address = (byte)binary
        };
    }
}