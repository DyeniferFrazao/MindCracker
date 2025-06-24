using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int id;
    public Sprite frontImage;

    [SerializeField] private Image imagemCarta;
    [SerializeField] private GameObject frente;
    [SerializeField] private GameObject costas;

    private GameManager gameManager;
    private bool bloqueada = false;

    public void ConfigurarCarta(int id, Sprite sprite, GameManager gm)
    {
        this.id = id;
        this.frontImage = sprite;
        this.gameManager = gm;
        imagemCarta.sprite = sprite;
        VirarPraTras(); // Começa virada
    }

    public void AoClicar()
    {
        if (bloqueada || frente.activeSelf) return;

        VirarPraFrente();
        gameManager.CartaClicada(this);
    }

    public void VirarPraFrente()
    {
        frente.SetActive(true);
        costas.SetActive(false);
    }

    public void VirarPraTras()
    {
        frente.SetActive(false);
        costas.SetActive(true);
    }

    public void Bloquear()
    {
        bloqueada = true;
    }
}
