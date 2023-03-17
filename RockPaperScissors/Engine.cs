namespace RockPaperScissors;

public enum PlayChoice
{
    Rock,
    Paper,
    Scissors
}

public enum PlayResult
{
    LeftWins,
    RightWins,
    Draw
}

public static class Engine
{
    public static PlayResult Play(PlayChoice leftChoice, PlayChoice rightChoice)
    {
        return leftChoice switch
        {
            PlayChoice.Rock => rightChoice switch
            {
                PlayChoice.Scissors => PlayResult.LeftWins,
                _ => throw new NotSupportedException()
            },
            PlayChoice.Scissors => rightChoice switch
            {
                PlayChoice.Rock => PlayResult.RightWins,
                _ => throw new NotSupportedException()
            },
            _ => throw new NotSupportedException()
        };
    }
}
