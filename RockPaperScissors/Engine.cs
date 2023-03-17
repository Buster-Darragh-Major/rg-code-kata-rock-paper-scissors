namespace RockPaperScissors;

public static class Engine
{
    public static GenericEngine<PlayChoice> CreateStandardEngine() =>
        new(new[]
        {
            (PlayChoice.Rock, PlayChoice.Scissors),
            (PlayChoice.Paper, PlayChoice.Rock),
            (PlayChoice.Scissors, PlayChoice.Paper)
        });

    public static GenericEngine<LizardVulcanPlayChoice> CreateLizardVulcanEngine() =>
        new(new[]
        {
            (LizardVulcanPlayChoice.Rock, LizardVulcanPlayChoice.Scissors),
            (LizardVulcanPlayChoice.Rock, LizardVulcanPlayChoice.Lizard),
            (LizardVulcanPlayChoice.Paper, LizardVulcanPlayChoice.Rock),
            (LizardVulcanPlayChoice.Paper, LizardVulcanPlayChoice.Vulcan),
            (LizardVulcanPlayChoice.Scissors, LizardVulcanPlayChoice.Paper),
            (LizardVulcanPlayChoice.Scissors, LizardVulcanPlayChoice.Lizard),
            (LizardVulcanPlayChoice.Vulcan, LizardVulcanPlayChoice.Rock),
            (LizardVulcanPlayChoice.Vulcan, LizardVulcanPlayChoice.Scissors),
            (LizardVulcanPlayChoice.Lizard, LizardVulcanPlayChoice.Paper),
            (LizardVulcanPlayChoice.Lizard, LizardVulcanPlayChoice.Vulcan)
        });
}
