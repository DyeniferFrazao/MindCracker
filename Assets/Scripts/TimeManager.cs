using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("Tempos por dificuldade (em segundos)")]
    public int tempoFacil = 10;
    public int tempoMedio = 5;
    public int tempoDificil = 3;

    [Header("Referências da UI")]
    public Text timerText; // Texto do timer no Canvas.
    public Text pairsText; // Texto da contagem de pares.

    private float tempoRestante;
    private bool jogoAtivo = true;

    void Start()
    {
        // Configura o tempo inicial com base na dificuldade.
        switch (GameSettings.dificuldadeAtual)
        {
            case Dificuldade.Facil:
                tempoRestante = tempoFacil;
                break;
            case Dificuldade.Medio:
                tempoRestante = tempoMedio;
                break;
            case Dificuldade.Dificil:
                tempoRestante = tempoDificil;
                break;
        }
        UpdateUI();
    }

    void Update()
    {
        if (jogoAtivo)
        {
            tempoRestante -= Time.deltaTime;
            if (tempoRestante <= 0)
            {
                tempoRestante = 0;
                jogoAtivo = false;
                Debug.Log("Tempo esgotado! Game Over!");
                // Aqui você pode chamar funções para finalizar o jogo.
            }
            UpdateUI();
        }
    }

    // Atualiza o display do timer.
    void UpdateUI()
    {
        if (timerText != null)
            timerText.text = "Tempo: " + Mathf.RoundToInt(tempoRestante).ToString();
    }

    // Método para atualizar a contagem de pares (chame de outro script ao acertar um par).
    public void AtualizarPares(int paresEncontrados, int totalPares)
    {
        if (pairsText != null)
            pairsText.text = "Pares: " + paresEncontrados.ToString() + "/" + totalPares.ToString();
    }

    // Caso queira reiniciar o timer ao reiniciar o jogo.
    public void ResetTimer()
    {
        switch (GameSettings.dificuldadeAtual)
        {
            case Dificuldade.Facil:
                tempoRestante = tempoFacil;
                break;
            case Dificuldade.Medio:
                tempoRestante = tempoMedio;
                break;
            case Dificuldade.Dificil:
                tempoRestante = tempoDificil;
                break;
        }
        jogoAtivo = true;
        UpdateUI();
    }
}
