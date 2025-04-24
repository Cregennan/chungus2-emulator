using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct NopInstruction : IChungusInstruction<NopInstruction>
{
    public static NopInstruction FromBinary(ushort binary) => new();
}