namespace Cregennan.Chungus2.Processor.Enums;

/// <summary>
/// Describes bitwise logic operations performed by <see cref="InstructionName.BIT"/> and <see cref="InstructionName.BNT"/> instructions.
/// <para><see cref="InstructionName.BNT"/> performes inverse variants of such operations.</para> 
/// </summary>
public enum BitwiseLogicInfo
{
    Implies = 0,
    Xor = 1,
    And = 2,
    Or = 3
}