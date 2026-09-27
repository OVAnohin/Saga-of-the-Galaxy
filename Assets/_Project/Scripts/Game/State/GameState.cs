using UnityEngine;

public class GameState
{
    public Galaxy Galaxy => _galaxy;

    private Galaxy _galaxy;
    private Player _player1;
    private Player _player2;

    public string ForTest => "GameState";

    public GameState()
    {
        _galaxy = new Galaxy();
        _player1 = new Player();
        _player2 = new Player();

        Debug.Log(Galaxy.ForTest);
        Debug.Log(_player1.ForTest);
        Debug.Log(_player2.ForTest);
    }
}
