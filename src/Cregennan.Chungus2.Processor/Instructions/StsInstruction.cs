using Cregennan.Chungus2.Processor.Interfaces;

namespace Cregennan.Chungus2.Processor.Instructions;

internal struct StsInstruction : IChungusInstruction<StsInstruction>
{
    public SettingInfo Setting { get; private set; }
    
    public byte Immediate { get; private set; }
    
    public static StsInstruction FromBinary(ushort binary)
    {
        return new StsInstruction
        {
            Setting = (SettingInfo)((binary >> 8) & 0b111),
            Immediate = (byte)(binary & 255)
        };
    }
    
    public enum SettingInfo
    {
        UseAlternameBranch = 0,
        ForceNotUpdate = 1,
        SetLoopCounter = 2,
        SetLoopSource = 3,
        SetStackPointerToImmediate = 4,
        Unused1 = 5,
        Unused2 = 6,
        Unused3 = 7
    }
}