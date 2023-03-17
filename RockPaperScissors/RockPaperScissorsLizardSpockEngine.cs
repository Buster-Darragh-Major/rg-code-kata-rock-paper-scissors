namespace RockPaperScissors;

public class LizardVulcanEngine : GenericEngine<LizardVulcanPlayChoice>
{
    public LizardVulcanEngine() : base(new []
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
    })
    {
    }
}
