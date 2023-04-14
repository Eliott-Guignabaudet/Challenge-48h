using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsScript : MonoBehaviour
{
    private int indexListCards = 0;
    private bool isSwip = false;
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
        else if (isSwip)
        {
            indexListCards += 1;
            gameObject.GetComponent<SpriteRenderer>().sprite = listeCartes.deck[indexListCards].image;
            isSwip = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isSwip = true;
        }
        /*else if (Input.GetKeyDown(KeyCode.D))
        {
            isSwip = true;
        }*/
    }


}
