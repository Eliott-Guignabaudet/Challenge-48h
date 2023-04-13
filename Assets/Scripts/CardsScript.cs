using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsScript : MonoBehaviour
{

    public Carte carteSO;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = carteSO.image;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
