using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [Header("Referências")]
    public BoardManager boardManager;
    public TimeManager timeManager;

   
    public void ReiniciarJogo()
    {
        boardManager.ResetBoard();
        timeManager.ResetTimer();
    }
    public void VoltarAoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
