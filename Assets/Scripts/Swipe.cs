using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public GameObject Square; //card
    public CardsScript cl;
    SpriteRenderer sr;
    float fMovingSpeed = 1f;
    void Awake()
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
                cl.SimulSwipRight();
            }
            sr.color = Color.green;

        }
        else if (Square.transform.position.x < -1.5)
        {
            sr.color = Color.red;
            if (Input.GetMouseButtonUp(0))
            {
                cl.SimulSwipLeft();
            }

        }
        else
        {
            sr.color = Color.white;
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
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));
                    float newPositionX = hit.point.x - touchPosition.x;
                    hit.transform.position = new Vector3(touchPosition.x, hit.transform.position.y, 0);
                    hit.transform.eulerAngles = new Vector3(0, 0, -touchPosition.x * 7);
                }


            }
        }
        else
        {
            Square.transform.position = Vector2.MoveTowards(Square.transform.position, new Vector2(0, 0), fMovingSpeed);
            Square.transform.rotation = Quaternion.identity;
        }


    }
}