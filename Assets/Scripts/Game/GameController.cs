using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject menuMain;
    public GameObject Reload;
    
    public void loadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }


    public void PauseGame()
    {
        Time.timeScale = 0f;
    }




    // Start is called before the first frame update
    void Start()
    {
        menuMain.SetActive(false);
        Reload.SetActive(false);

    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void showMenuMain()
    {
        menuMain.SetActive(true);
        
    }

    public void ResettheScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;

    }

    public void showReload()
    {
        Reload.SetActive(true);
    }


}
