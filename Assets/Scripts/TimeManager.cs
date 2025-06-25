using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("Tempos por dificuldade (em segundos)")]
    public int tempoFacil = 20;
    public int tempoMedio = 15;
    public int tempoDificil = 7;

    [Header("Referências da UI")]
    public Text timerText; 
    public Text pairsText; 

    private float tempoRestante;
    private bool jogoAtivo = true;

    void Start()
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
            }
            UpdateUI();
        }
    }

    
    void UpdateUI()
    {
        if (timerText != null)
            timerText.text = "Tempo: " + Mathf.RoundToInt(tempoRestante).ToString();
    }

    
    public void AtualizarPares(int paresEncontrados, int totalPares)
    {
        if (pairsText != null)
            pairsText.text = "Pares: " + paresEncontrados.ToString() + "/" + totalPares.ToString();
    }

    
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
