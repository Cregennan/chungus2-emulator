using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct PldInstruction : IChungusInstruction<PldInstruction>
{
    public byte Destination { get; internal set; }
    
    public byte PortAddress { get; internal set; }
    
    public static PldInstruction FromBinary(ushort binary)
    {
        return new PldInstruction
        {
            Destination = (byte)((binary >> 8) & 0b111),
            PortAddress = (byte)(binary & 255)
        };
    }
}