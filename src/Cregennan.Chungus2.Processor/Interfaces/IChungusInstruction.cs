namespace Cregennan.Chungus2.Processor.Interfaces;

public interface IChungusInstruction<TInstruction>
{
    public static abstract TInstruction FromBinary(ushort word);
}