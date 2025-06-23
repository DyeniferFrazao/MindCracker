using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    [Header("Referências")]
    public GameObject cardPrefab; // Template da carta (deixe esse prefab configurado com sua arte/funcionalidade).
    public Transform gridParent;  // Painel manual do grid onde as cartas serão instanciadas.

    private int rows;
    private int columns;

    void Start()
    {
        // Configura a quantidade de linhas e colunas conforme a dificuldade selecionada.
        switch (GameSettings.dificuldadeAtual)
        {
            case Dificuldade.Facil:
                rows = 4;
                columns = 4;
                break;
            case Dificuldade.Medio:
                rows = 4;
                columns = 6;
                break;
            case Dificuldade.Dificil:
                rows = 5;
                columns = 6;
                break;
        }

        // Ajusta o GridLayoutGroup para exibir corretamente as colunas.
        GridLayoutGroup gridLayout = gridParent.GetComponent<GridLayoutGroup>();
        if (gridLayout != null)
            gridLayout.constraintCount = columns;

        GenerateBoard();
    }

    // Gera o tabuleiro limpando o grid e recriando as cartas.
    void GenerateBoard()
    {
        // Remove cartas anteriores (para reinicializações).
        foreach (Transform child in gridParent)
        {
            Destroy(child.gameObject);
        }

        int totalCards = rows * columns;
        for (int i = 0; i < totalCards; i++)
        {
            GameObject card = Instantiate(cardPrefab, gridParent);
            card.name = "Card_" + i;
            card.SetActive(true);
            // Aqui, você pode adicionar scripts para o “flip” da carta,
            // atribuir a imagem correta, etc.
        }
    }

    // Método público para reiniciar o tabuleiro (útil para o botão de reiniciar).
    public void ResetBoard()
    {
        GenerateBoard();
    }
}
