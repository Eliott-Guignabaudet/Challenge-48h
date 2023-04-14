using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class AllCards : MonoBehaviour
{
    public Carte didactitielCard;
    public List<Carte> deck = new List<Carte>();
    public static int nbCartesInDeck;
    /*private int[] listIndexCartes = new int[nbCartesInDeck];
    private bool isIndexValid = false;*/

    void Awake()
    {
        System.Random random = new System.Random();
        var shuffled = deck.OrderBy(_ => random.Next()).ToList();
        deck = shuffled.Take(21).ToList();
        deck[0] = didactitielCard;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
