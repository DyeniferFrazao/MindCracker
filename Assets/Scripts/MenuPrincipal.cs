using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    public void Facil()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Facil;
        SceneManager.LoadScene("JogoFacil");
    }

    public void Medio()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Medio;
        SceneManager.LoadScene("JogoMedio");
    }

    public void Dificil()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Dificil;
        SceneManager.LoadScene("JogoDificil");
    }
}
