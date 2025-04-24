using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct PshInstruction : IChungusInstruction<PshInstruction>
{
    public GeneralRegisterInfo Source { get; internal set; }
    
    /// <summary>
    /// Do not update stack pointer
    /// </summary>
    public bool U { get; internal set; }
    
    /// <summary>
    /// Do not push to memory (only update stack pointer)
    /// </summary>
    public bool W { get; internal set; }
    
    public sbyte Offset { get; internal set; }
    
    public static PshInstruction FromBinary(ushort word)
    {
        return new PshInstruction
        {
            Source = (GeneralRegisterInfo)((word >> 8) & 0b111),
            U = (word & 0b1000_0000) == 0b1000_0000,
            W = (word & 0b0100_0000) == 0b0100_0000,
            Offset = word.ToSignedExtension(6)
        };
    }
}