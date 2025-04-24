using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct CmaInstruction : IChungusInstruction<CmaInstruction>
{
    public GeneralRegisterInfo Source { get; internal set; }
    
    public byte Immediate { get; internal set; }
    
    public static CmaInstruction FromBinary(ushort word)
    {
        return new CmaInstruction
        {
            Source = word.ToRegisterByFirstByte(),
            Immediate = (byte)(word >> 8)
        };
    }
}