namespace TikTakToe;

public class TicTacToeTests
{
    [Fact]
    public void StartGame_NoWinner()
    {
        var game = new TicTacToe();
        Assert.False(game.HasWinner());
    }
}

public class TicTacToe
{
    public bool HasWinner()
    {
        return false;
    }
}
