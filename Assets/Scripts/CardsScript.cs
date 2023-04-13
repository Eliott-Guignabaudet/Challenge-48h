using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsScript : MonoBehaviour
{

    public Carte carteSO;
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = carteSO.image;
    }

}
