using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject endPanel;

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        if (SceneManager.GetActiveScene().name == "SampleSceneYnov")
        {
            GameObject.Find("CarteParent").GetComponent<CardsScript>().StartGame();
            Player player = GameObject.Find("Player").GetComponent<Player>();
            player.Hunger = 70;
            player.Sold = 70;
            player.Social = 70;
            player.Knowledge = 70;
        }
    }

    public void GameOver(string message)
    {
        endPanel.SetActive(true);
        endPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = message;
        GameObject.Find("CarteParent").SetActive(false);
        GameObject.Find("Swipe").SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayYnov()
    {
        SceneManager.LoadScene("SampleSceneYnov");
    }
}
