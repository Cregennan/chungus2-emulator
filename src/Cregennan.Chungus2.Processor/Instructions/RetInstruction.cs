using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct RetInstruction : IChungusInstruction<RetInstruction>
{
    public static RetInstruction FromBinary(ushort binary) => new();
}