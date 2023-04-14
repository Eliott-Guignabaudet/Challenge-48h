using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class AllCards : MonoBehaviour
{

    public List<Carte> deck = new List<Carte>();
    public static int nbCartesInDeck;
    /*private int[] listIndexCartes = new int[nbCartesInDeck];
    private bool isIndexValid = false;*/

    void Awake()
    {
        System.Random random = new System.Random();
        var shuffled = deck.OrderBy(_ => random.Next()).ToList();
        deck = shuffled.Take(20).ToList();

        /*for (int i = 0; i < nbCartesInDeck; i++){
             int index = Random.Range(0, 30);
             for (int indexCartesInList = 0; indexCartesInList <= listIndexCartes.Length; indexCartesInList++)
             {
                if (index != listIndexCartes[indexCartesInList])
                 {
                     isIndexValid = true;
                 }else if (listIndexCartes.Length == 0)
                 {
                     isIndexValid = true;
                 }

             }
             if (isIndexValid)
             {

                 isIndexValid = false;
             }
             Debug.Log(index);
            listIndexCartes[i] = index;
         }
         Debug.Log(listIndexCartes);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
