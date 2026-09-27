using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private GameState _gameState;

    public void StartGame()
    {
        _gameState = new GameState();
        Debug.Log(_gameState.ForTest);
    }
}
