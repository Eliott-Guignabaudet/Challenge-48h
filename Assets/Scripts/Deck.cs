using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deck : MonoBehaviour
{

    public List<Carte> deck = new List<Carte>();
    public static int nbCartesInDeck = 20;
    private int[] listIndexCartes = new int[nbCartesInDeck];
    private bool isIndexValid = false;

    void Start()
    {

       for (int i = 0; i < nbCartesInDeck; i++){
            int index = Random.Range(0, 30);
            /*for (int indexCartesInList = 0; indexCartesInList <= listIndexCartes.Length; indexCartesInList++)
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
            }*/
            Debug.Log(index);
           listIndexCartes[i] = index;
        }
        Debug.Log(listIndexCartes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
