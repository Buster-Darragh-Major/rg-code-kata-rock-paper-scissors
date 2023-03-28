namespace RockPaperScissors;

public class GenericEngine<TGesture>
{
    private readonly ISet<(TGesture leftChoice, TGesture rightChoice)> _winningPlays;

    public GenericEngine(IEnumerable<(TGesture leftChoice, TGesture rightChoice)> winningPlays) =>
        _winningPlays = winningPlays.ToHashSet();

    public PlayResult Play(TGesture leftChoice, TGesture rightChoice) =>
        _winningPlays.Contains((leftChoice, rightChoice))
            ? PlayResult.LeftWins
            : _winningPlays.Contains((rightChoice, leftChoice))
                ? PlayResult.RightWins
                : PlayResult.Draw;
}
