using FluentAssertions;
using NUnit.Framework;
using RockPaperScissors;

namespace RockPaperScissorsTests;

[TestFixture]
public class EngineTests
{
    [Test]
    public void RockBeatsScissors_LeftWins()
    {
        Engine.Play(PlayChoice.Rock, PlayChoice.Scissors).Should().Be(PlayResult.LeftWins);
    }

    [Test]
    public void RockBeatsScissors_RightWins()
    {
        Engine.Play(PlayChoice.Scissors, PlayChoice.Rock).Should().Be(PlayResult.RightWins);
    }
}
