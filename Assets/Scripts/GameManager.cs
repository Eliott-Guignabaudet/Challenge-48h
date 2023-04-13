using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Slider hungerBar;
    public Slider soldBar;
    public Slider socialBar;
    public Slider knowledgeBar;

    private int _hunger, _sold, _social, _knowledge;

    public int Hunger
    {
        get { return _hunger; }
        set { 
            _hunger = value;
            hungerBar.value = value;
        }
    }

    public int Sold
    {
        get { return _sold; }
        set
        {
            _sold = value;
            soldBar.value = value;
        }
    }

    public int Social
    {
        get { return _social; }
        set
        {
            _social = value;
            socialBar.value = value;
        }
    }

    public int Knowledge
    {
        get { return _knowledge; }
        set
        {
            _knowledge = value;
            knowledgeBar.value = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Hunger = 50;
        Sold = 50;
        Social = 50;
        Knowledge = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
