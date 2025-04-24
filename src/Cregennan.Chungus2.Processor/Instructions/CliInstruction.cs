using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct CliInstruction : IChungusInstruction<CliInstruction>
{
    public byte Destination { get; internal set; }
    
    public ConditionInfo Condition { get; internal set; }
    
    public sbyte Immediate { get; internal set; }

    public static CliInstruction FromBinary(ushort word)
    {
        return new CliInstruction
        {
            Destination = (byte)((word >> 8) & 0b111),
            Condition = (ConditionInfo)((word >> 5) & 0b111),
            Immediate = word.ToSignedExtension(5)
        };
    }
}