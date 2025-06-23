using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    public void Facil()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Facil;
        SceneManager.LoadScene("GameScene");
    }

    public void Medio()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Medio;
        SceneManager.LoadScene("GameScene");
    }

    public void Dificil()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Dificil;
        SceneManager.LoadScene("GameScene");
    }
}
