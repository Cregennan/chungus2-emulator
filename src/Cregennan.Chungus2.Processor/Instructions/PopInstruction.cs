using Cregennan.Chungus2.Processor.Enums;
using Cregennan.Chungus2.Processor.Extensions;
using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct PopInstruction : IChungusInstruction<PopInstruction>
{
    public GeneralRegisterInfo Destination { get; internal set; }
    
    /// <summary>
    /// Do not update stack pointer
    /// </summary>
    public bool U { get; internal set; }
    
    /// <summary>
    /// Do not push to memory (only update stack pointer)
    /// </summary>
    public bool W { get; internal set; }
    
    public sbyte Offset { get; internal set; }
    
    public static PopInstruction FromBinary(ushort binary)
    {
        return new PopInstruction
        {
            Destination = (GeneralRegisterInfo)((binary >> 8) & 0b111),
            U = (binary & 0b1000_0000) == 0b1000_0000,
            W = (binary & 0b0100_0000) == 0b0100_0000,
            Offset = binary.ToSignedExtension(6)
        };
    }
}