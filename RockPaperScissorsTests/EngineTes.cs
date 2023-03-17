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
    public void TestPlay(PlayChoice LeftChoice, PlayChoice RightChoice, PlayResult ExpectedResult)
    {
        Engine.Play(LeftChoice, RightChoice).Should().Be(ExpectedResult);
    }
}
