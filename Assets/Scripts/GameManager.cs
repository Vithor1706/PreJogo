using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public enum Turn { Player, Enemy }
    public Turn currentTurn;

    public GameObject[] playerCharacters;
    public GameObject[] enemyCharacters;

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        currentTurn = Turn.Player;  // O jogador começa
        // Exibir interface para seleção de ações do jogador
    }

    public void EndTurn()
    {
        if (currentTurn == Turn.Player)
        {
            currentTurn = Turn.Enemy;
            // Lógica para o turno do inimigo (pode ser automatizado ou controlado)
        }
        else
        {
            currentTurn = Turn.Player;
            // Exibir interface para o turno do jogador
        }
    }
}
