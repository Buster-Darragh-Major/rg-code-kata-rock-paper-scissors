namespace RockPaperScissors;

public class StandardEngine : GenericEngine<PlayChoice>
{
    public StandardEngine() : base(new[]
    {
        (PlayChoice.Rock, PlayChoice.Scissors),
        (PlayChoice.Paper, PlayChoice.Rock),
        (PlayChoice.Scissors, PlayChoice.Paper)
    })
    {
    }
}
