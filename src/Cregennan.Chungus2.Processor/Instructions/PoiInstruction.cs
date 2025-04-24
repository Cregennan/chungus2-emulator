using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct PoiInstruction : IChungusInstruction<PoiInstruction>
{
    public bool KeepUntilOverwritten { get; internal set; }
    
    public byte SourceB { get; internal set; }
    
    public static PoiInstruction FromBinary(ushort binary)
    {
        return new PoiInstruction
        {
            KeepUntilOverwritten = (binary & 0b1_0000_0000) == 0b1_0000_0000,
            SourceB = (byte)(binary & 0b111)
        };
    }
}