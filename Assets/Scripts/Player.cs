using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
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
            if (_hunger > 100) _hunger = 100;
            hungerBar.value = _hunger;

        }
    }

    public int Sold
    {
        get { return _sold; }
        set
        {
            _sold = value;
            if (_sold > 100) _sold = 100;
            soldBar.value = _sold;
        }
    }

    public int Social
    {
        get { return _social; }
        set
        {
            _social = value;
            if (_social > 100) _social = 100;
            socialBar.value = _social;
        }
    }

    public int Knowledge
    {
        get { return _knowledge; }
        set
        {
            _knowledge = value;
            if (_knowledge > 100) _knowledge = 100;
            knowledgeBar.value = _knowledge;
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
    public void AddRemoveHunger(int value)
    {
        Hunger += value;
    }    

    public void AddRemoveSold(int value)
    {
        Sold += value;
    }

    public void AddRemoveSocial(int value)
    {
        Social += value;
    }

    public void AddRemoveKnowledge(int value)
    {
        Knowledge += value;
    }
}
