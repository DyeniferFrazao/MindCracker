using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> todasAsCartas; 
    public Sprite[] spritesFaseAtual;

    private Card primeiraCarta, segundaCarta;

    void Start()
    {
        SortearCartas();
    }

    void SortearCartas()
    {
        int pares = todasAsCartas.Count / 2;
        List<int> ids = new();

        for (int i = 0; i < pares; i++)
        {
            ids.Add(i);
            ids.Add(i);
        }

        Embaralhar(ids);

        for (int i = 0; i < todasAsCartas.Count; i++)
        {
            todasAsCartas[i].ConfigurarCarta(ids[i], spritesFaseAtual[ids[i]], this);
        }
    }

    public void CartaClicada(Card carta)
    {
        if (primeiraCarta == null)
        {
            primeiraCarta = carta;
            return;
        }

        segundaCarta = carta;
        StartCoroutine(VerificarPar());
    }

    System.Collections.IEnumerator VerificarPar()
    {
        yield return new WaitForSeconds(0.5f);

        if (primeiraCarta.id == segundaCarta.id)
        {
            primeiraCarta.Bloquear();
            segundaCarta.Bloquear();
        }
        else
        {
            primeiraCarta.VirarPraTras();
            segundaCarta.VirarPraTras();
        }

        primeiraCarta = null;
        segundaCarta = null;
    }

    void Embaralhar(List<int> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            int rnd = Random.Range(i, lista.Count);
            (lista[i], lista[rnd]) = (lista[rnd], lista[i]);
        }
    }
}