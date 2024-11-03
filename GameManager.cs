using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public GameObject ball;

    void Start()
    {
        // Inicializar el juego
        ball.transform.position = player.transform.position + Vector3.forward;
    }

    public void EndGame()
    {
        // Mostrar resultados finales
        Debug.Log("Fin del juego. Puntuación total: " + player.score);
    }
}
