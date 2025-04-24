using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

public struct HltInstruction : IChungusInstruction<HltInstruction>
{
    public static HltInstruction FromBinary(ushort binary) => new();
}