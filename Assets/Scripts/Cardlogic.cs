using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardlogic : MonoBehaviour
{
    TMPro.TextMeshPro tmp;
    public bool isMouseOver = false;
    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }



    public void InduceRight()
    {
        Debug.Log("Swipe a Droite");
    }

    public void InduceLeft()
    {
        Debug.Log("Swipe a Gauche");
    }

}