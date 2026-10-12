using System;

// ===================================================================================
// SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS REPORT:
// I exceeded the base functional requirements by implementing a dynamic Leveling and 
// Ranking system inside the `GoalManager`. Players now gain milestone ranks every 
// 500 points (e.g., Level 1 Adventurer, Level 2 Adventurer). This enhances user gamification 
// and gives users an extra short-term reward milestone to look forward to.
// ===================================================================================

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
