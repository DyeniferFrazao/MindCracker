using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [Header("Referências")]
    public BoardManager boardManager;
    public TimeManager timeManager;

    // Chamado pelo botão de reiniciar.
    public void ReiniciarJogo()
    {
        boardManager.ResetBoard();
        timeManager.ResetTimer();
    }

    // Chamado pelo botão de voltar ao menu.
    public void VoltarAoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
