using FluentAssertions;
using NUnit.Framework;
using RockPaperScissors;

namespace RockPaperScissorsTests;

[TestFixture]
public class EngineTests
{
    [TestCase(PlayChoice.Rock, PlayChoice.Scissors, PlayResult.LeftWins)]
    [TestCase(PlayChoice.Rock, PlayChoice.Paper, PlayResult.RightWins)]
    [TestCase(PlayChoice.Rock, PlayChoice.Rock, PlayResult.Draw)]

    [TestCase(PlayChoice.Scissors, PlayChoice.Paper, PlayResult.LeftWins)]
    [TestCase(PlayChoice.Scissors, PlayChoice.Rock, PlayResult.RightWins)]
    [TestCase(PlayChoice.Scissors, PlayChoice.Scissors, PlayResult.Draw)]

    [TestCase(PlayChoice.Paper, PlayChoice.Rock, PlayResult.LeftWins)]
    [TestCase(PlayChoice.Paper, PlayChoice.Scissors, PlayResult.RightWins)]
    [TestCase(PlayChoice.Paper, PlayChoice.Paper, PlayResult.Draw)]
    public void TestStandardEngine(PlayChoice LeftChoice, PlayChoice RightChoice, PlayResult ExpectedResult)
    {
        new StandardEngine().Play(LeftChoice, RightChoice).Should().Be(ExpectedResult);
    }

    [TestCase(LizardVulcanPlayChoice.Rock, LizardVulcanPlayChoice.Rock, PlayResult.Draw)]
    [TestCase(LizardVulcanPlayChoice.Rock, LizardVulcanPlayChoice.Paper, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Rock, LizardVulcanPlayChoice.Scissors, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Rock, LizardVulcanPlayChoice.Lizard, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Rock, LizardVulcanPlayChoice.Vulcan, PlayResult.RightWins)]

    [TestCase(LizardVulcanPlayChoice.Paper, LizardVulcanPlayChoice.Rock, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Paper, LizardVulcanPlayChoice.Paper, PlayResult.Draw)]
    [TestCase(LizardVulcanPlayChoice.Paper, LizardVulcanPlayChoice.Scissors, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Paper, LizardVulcanPlayChoice.Lizard, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Paper, LizardVulcanPlayChoice.Vulcan, PlayResult.LeftWins)]

    [TestCase(LizardVulcanPlayChoice.Scissors, LizardVulcanPlayChoice.Rock, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Scissors, LizardVulcanPlayChoice.Paper, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Scissors, LizardVulcanPlayChoice.Scissors, PlayResult.Draw)]
    [TestCase(LizardVulcanPlayChoice.Scissors, LizardVulcanPlayChoice.Lizard, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Scissors, LizardVulcanPlayChoice.Vulcan, PlayResult.RightWins)]

    [TestCase(LizardVulcanPlayChoice.Lizard, LizardVulcanPlayChoice.Rock, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Lizard, LizardVulcanPlayChoice.Paper, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Lizard, LizardVulcanPlayChoice.Scissors, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Lizard, LizardVulcanPlayChoice.Lizard, PlayResult.Draw)]
    [TestCase(LizardVulcanPlayChoice.Lizard, LizardVulcanPlayChoice.Vulcan, PlayResult.LeftWins)]

    [TestCase(LizardVulcanPlayChoice.Vulcan, LizardVulcanPlayChoice.Rock, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Vulcan, LizardVulcanPlayChoice.Paper, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Vulcan, LizardVulcanPlayChoice.Scissors, PlayResult.LeftWins)]
    [TestCase(LizardVulcanPlayChoice.Vulcan, LizardVulcanPlayChoice.Lizard, PlayResult.RightWins)]
    [TestCase(LizardVulcanPlayChoice.Vulcan, LizardVulcanPlayChoice.Vulcan, PlayResult.Draw)]
    public void TestLizardVulcanEngine(
        LizardVulcanPlayChoice LeftChoice, LizardVulcanPlayChoice RightChoice, PlayResult ExpectedResult)
    {
        new LizardVulcanEngine().Play(LeftChoice, RightChoice).Should().Be(ExpectedResult);
    }
}
