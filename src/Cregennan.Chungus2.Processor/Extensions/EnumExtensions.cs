using Cregennan.Chungus2.Processor.Enums;

namespace Cregennan.Chungus2.Processor.Extensions;

public static class EnumExtensions
{
    public static ExplicitConditionInfo ToExplicit(this ConditionInfo info, bool useAlternateConditions)
    {
        return info switch
        {
            ConditionInfo.True => ExplicitConditionInfo.True,
            ConditionInfo.Even => ExplicitConditionInfo.Even,
            ConditionInfo.HigherLessEqual => useAlternateConditions ? ExplicitConditionInfo.Higher : ExplicitConditionInfo.LessEqual,
            ConditionInfo.LowerGreaterEqual => useAlternateConditions ? ExplicitConditionInfo.Lower : ExplicitConditionInfo.GreaterEqual,
            ConditionInfo.ZeroEqual => useAlternateConditions ? ExplicitConditionInfo.Zero : ExplicitConditionInfo.Equal,
            ConditionInfo.NotZeroNotEqual => useAlternateConditions ? ExplicitConditionInfo.NotZero : ExplicitConditionInfo.NotEqual,
            ConditionInfo.HigherSameLess => useAlternateConditions ? ExplicitConditionInfo.HigherSame : ExplicitConditionInfo.Less,
            ConditionInfo.LowerSameGreater => useAlternateConditions ? ExplicitConditionInfo.LowerSame : ExplicitConditionInfo.Greater,
            _ => throw new ArgumentOutOfRangeException(nameof(info), info, null)
        };
    }
}