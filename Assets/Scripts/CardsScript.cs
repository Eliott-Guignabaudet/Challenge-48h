using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class CardsScript : MonoBehaviour
{
    public Player player;
    private int indexListCards = 0;
    public bool isSwipLeft = false;
    public bool isSwipRight = false;
    public AllCards listeCartes;
    private Sprite ActualFrontSprite;
    public AudioSource ReturnCard;
    [SerializeField] private Sprite BackSprite;
    
    

    public void StartGame()
    {

        ActualFrontSprite = listeCartes.deck[indexListCards].image;
        StartCoroutine(AnimationCardCoroutine());

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
            Debug.Log(listeCartes.deck[indexListCards]);
            //Appliquer les malus/bonus à l'UI barres etat
            player.AddRemoveHunger(listeCartes.deck[indexListCards].statsGauche.influenceHunger);
            player.AddRemoveKnowledge(listeCartes.deck[indexListCards].statsGauche.influenceKnowledge);
            player.AddRemoveSocial(listeCartes.deck[indexListCards].statsGauche.influenceSocial);
            player.AddRemoveSold(listeCartes.deck[indexListCards].statsGauche.influenceSold);
            indexListCards += 1;
            ActualFrontSprite = listeCartes.deck[indexListCards].image;
            StartCoroutine(AnimationCardCoroutine());
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
            ActualFrontSprite = listeCartes.deck[indexListCards].image;
            StartCoroutine(AnimationCardCoroutine());
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

    IEnumerator AnimationCardCoroutine()
    {
        GetComponent<Animator>().enabled = true;
        GetComponent<Animator>().SetTrigger("Swipe");
        ReturnCard.Play();
        GetComponent<SpriteRenderer>().sprite = BackSprite;
        yield return new WaitForSeconds(0.20f);
        GetComponent<SpriteRenderer>().sprite = ActualFrontSprite;
        yield return new WaitForSeconds(0.20f);
        ReturnCard.Stop();
        GetComponent<Animator>().enabled = false;

    }

}
