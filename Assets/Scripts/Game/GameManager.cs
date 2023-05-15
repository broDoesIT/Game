using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    static int score = 0;
    static int scoreCount = 0;
    public TMP_Text ScoreText;
    public GameObject gameOverImage;
    PlayerController gameControler;
    GameController ShowMenu;
    
    private void Start()
    {
        
        ScoreText.text = "༺score: " + score + "༻";
        gameOverImage.SetActive(false);
        gameControler = GameObject.Find("Player").GetComponent<PlayerController>();
        ShowMenu = GameObject.Find("GameController").GetComponentInParent<GameController>();
        
    }

    private void Update()
    {
        ScoreText.text = ".:[score: " + score + "]:.";
        if(scoreCount>=10)
        {
           gameControler.Uplevel();
           scoreCount = 0;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverImage.SetActive(true);
        ShowMenu.showMenuMain();
        ShowMenu.showReload();
        score = 0;
        scoreCount = 0;
    }

    public void IncreaseScore()
    {
        score++;
        scoreCount++;
        
    }


    


}
