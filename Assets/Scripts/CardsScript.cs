using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsScript : MonoBehaviour
{
    public Player player;
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
            player.Win();
        }
        else if (isSwipLeft)
        {
            //Appliquer les malus/bonus à l'UI barres etat
            player.AddRemoveHunger(listeCartes.deck[indexListCards].statsGauche.influenceHunger);
            player.AddRemoveKnowledge(listeCartes.deck[indexListCards].statsGauche.influenceKnowledge);
            player.AddRemoveSocial(listeCartes.deck[indexListCards].statsGauche.influenceSocial);
            player.AddRemoveSold(listeCartes.deck[indexListCards].statsGauche.influenceSold);
            indexListCards += 1;
            gameObject.GetComponent<SpriteRenderer>().sprite = listeCartes.deck[indexListCards].image;
            isSwipLeft = false;
        }
        else if (isSwipRight)
        {
            //Appliquer les malus/bonus à l'UI barres etat
            player.AddRemoveHunger(listeCartes.deck[indexListCards].statsDroite.influenceHunger);
            player.AddRemoveKnowledge(listeCartes.deck[indexListCards].statsDroite.influenceKnowledge);
            player.AddRemoveSocial(listeCartes.deck[indexListCards].statsDroite.influenceSocial);
            player.AddRemoveSold(listeCartes.deck[indexListCards].statsDroite.influenceSold);
            indexListCards += 1;
            gameObject.GetComponent<SpriteRenderer>().sprite = listeCartes.deck[indexListCards].image;
            isSwipRight = false;
        }
    }

    public void SimulSwipLeft()
    {
        isSwipLeft = true;
    }

    public void SimulSwipRight()
    {
        isSwipRight = true;
    }

}
