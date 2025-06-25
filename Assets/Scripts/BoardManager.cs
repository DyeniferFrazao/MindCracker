using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    [Header("Referências")]
    public GameObject cardPrefab;
    public Transform gridParent;

    private int rows;
    private int columns;

    void Start()
    {
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

        
        GridLayoutGroup gridLayout = gridParent.GetComponent<GridLayoutGroup>();
        if (gridLayout != null)
          gridLayout.constraintCount = columns;

        GenerateBoard();
    }

    
    void GenerateBoard()
    {
        
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
            
        }
    }

   
    public void ResetBoard()
    {
        GenerateBoard();
    }
}
