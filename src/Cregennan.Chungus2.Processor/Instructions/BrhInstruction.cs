using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct BrhInstruction : IChungusInstruction<BrhInstruction>
{
    public ConditionInfo ConditionInfo { get; internal set; }
    
    public bool BranchTaken { get; internal set; }
    
    public byte LocationOnPage { get; internal set; }
    
    public static BrhInstruction FromBinary(ushort binary)
    {
        return new BrhInstruction
        {
            ConditionInfo = (ConditionInfo)((binary >> 8) & 0b111),
            BranchTaken = (binary & 0b10000000) == 0b10000000,
            LocationOnPage = (byte)(binary & 0b111111)
        };
    }
}