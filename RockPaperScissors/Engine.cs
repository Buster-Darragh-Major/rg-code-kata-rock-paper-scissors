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
                PlayChoice.Rock => PlayResult.Draw,
                PlayChoice.Paper => PlayResult.RightWins,
                PlayChoice.Scissors => PlayResult.LeftWins,
                _ => throw new NotSupportedException()
            },
            PlayChoice.Paper => rightChoice switch
            {
                PlayChoice.Rock => PlayResult.LeftWins,
                PlayChoice.Paper => PlayResult.Draw,
                PlayChoice.Scissors => PlayResult.RightWins,
                _ => throw new NotSupportedException()
            },
            PlayChoice.Scissors => rightChoice switch
            {
                PlayChoice.Rock => PlayResult.RightWins,
                PlayChoice.Paper => PlayResult.LeftWins,
                PlayChoice.Scissors => PlayResult.Draw,
                _ => throw new NotSupportedException()
            },
            _ => throw new NotSupportedException()
        };
    }
}
