using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct PstInstruction : IChungusInstruction<PstInstruction>
{
    public byte Source { get; internal set; }
    
    public byte PortAddress { get; internal set; }
    
    public static PstInstruction FromBinary(ushort binary)
    {
        return new PstInstruction
        {
            Source = (byte)((binary >> 8) & 0b111),
            PortAddress = (byte)(binary & 255)
        };
    }
}