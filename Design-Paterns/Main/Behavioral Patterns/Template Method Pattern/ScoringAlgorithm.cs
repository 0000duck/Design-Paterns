using System;

namespace Main.Behavioral_Patterns.Template_Method_Pattern
{
    public abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        public abstract int CalculateBaseScore(int hits);

        public abstract int CalculateReduction(TimeSpan time);

        public abstract int CalculateOverallScore(int score, int reduction);
    }
}
