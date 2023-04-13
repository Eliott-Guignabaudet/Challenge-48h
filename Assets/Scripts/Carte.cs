using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Carte : ScriptableObject
{


    public Sprite image;
    public Stats statsGauche;
    public Stats statsDroite;



    [System.Serializable]
    public struct Stats
    {
        public int influenceHunger;
        public int influenceSocial;
        public int influenceSold;
        public int influenceKnowledge;
    }



}
