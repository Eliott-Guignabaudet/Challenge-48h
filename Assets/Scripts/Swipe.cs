using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public GameObject Square; //card
    public Cardlogic cl;
    SpriteRenderer sr;
    float fMovingSpeed = 1f;
    void Start()
    {
        sr = Square.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0) && cl.isMouseOver)
        //{
        //    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Square.transform.position = pos;
        //}
        //else
        //{
        //    Square.transform.position = Vector2.MoveTowards(Square.transform.position, new Vector2(0, 0), fMovingSpeed);
        //}

        if (Square.transform.position.x > 1.5)
        {
            if (Input.GetMouseButtonUp(0))
            {
                cl.InduceRight();
            }
            sr.color = Color.green;

        }
        else if (Square.transform.position.x < -1.5)
        {
            sr.color = Color.red;
            if (Input.GetMouseButtonUp(0))
            {
                cl.InduceLeft();
            }

        }
        else
        {
            sr.color = Color.blue;
        }
        if (Input.touchCount > 0)
        {
            Touch[] myTouches = Input.touches;
            foreach (Touch touch in myTouches)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    hit.transform.position =Camera.main.ScreenToWorldPoint( new Vector3(touch.position.x, touch.position.y, 0));
                    hit.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, 0);
                }


            }
        }
        else
        {
            Square.transform.position = Vector2.MoveTowards(Square.transform.position, new Vector2(0, 0), fMovingSpeed);
        }


    }
}