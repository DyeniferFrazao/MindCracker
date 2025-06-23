using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    public void Facil()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Facil;
        SceneManager.LoadScene("TelaDoJogo");
    }

    public void Medio()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Medio;
        SceneManager.LoadScene("TelaDoJogo");
    }

    public void Dificil()
    {
        GameSettings.dificuldadeAtual = Dificuldade.Dificil;
        SceneManager.LoadScene("TelaDoJogo");
    }
}