namespace Cregennan.Chungus2.Processor.Services;

public class ProcessorInnerState
{
    internal readonly byte[] Ram = new byte[256];
    internal readonly SettingInfo Settings = new();
    internal readonly FlagsInfo Flags = new();
    internal readonly byte[] Registries = new byte[8];
    
    
    
    public class SettingInfo
    {
        public bool UseAlternateBranchConditions;
        public bool SetLoopCounter;
        public bool SetLoopSource;
        public bool SetStackPointerToImmediate;
    }

    public class FlagsInfo
    {
        public bool Carry;
        public bool Zero;
        public bool Even;
    }
}