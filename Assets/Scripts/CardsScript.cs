using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsScript : MonoBehaviour
{
    private int indexListCards = 0;
    public bool isSwipLeft = false;
    public bool isSwipRight = false;
    public AllCards listeCartes;
    void Start()
    {
        
        gameObject.GetComponent<SpriteRenderer>().sprite = listeCartes.deck[indexListCards].image;

    }

    void Update()
    {
        if (indexListCards == listeCartes.deck.Count)
        {
            Debug.Log("Fin du jeu");
        }
        else if (isSwipLeft)
        {
            //Appliquer les malus/bonus à l'UI barres etat
            indexListCards += 1;
            gameObject.GetComponent<SpriteRenderer>().sprite = listeCartes.deck[indexListCards].image;
            isSwipLeft = false;
        }
    }

    public void SimulSwipLeft()
    {
        isSwipLeft = true;
    }


}
