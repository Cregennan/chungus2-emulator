using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct CmpInstruction : IChungusInstruction<CmpInstruction>
{
    public GeneralRegisterInfo Source { get; internal set; }
    
    public byte Immediate { get; internal set; }
    
    public static CmpInstruction FromBinary(ushort word)
    {
        return new CmpInstruction
        {
            Source = word.ToRegisterByFirstByte(),
            Immediate = (byte)(word >> 8)
        };
    }
}