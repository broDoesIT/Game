using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static int PlayerLevel = 1;
    private float speed = 4f;
    
    Rigidbody2D db;
    float XS = 0.2f, YS = 0.2f;
    AudioController audioControler;
    
    // Start is called before the first frame update
    void Start()
    {
        
        audioControler = GameObject.Find("Main Camera").GetComponent<AudioController>();
        db = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterScale = transform.localScale;


        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            flipD(-1f);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            flipD(1f);

        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }

    public void Uplevel()
    {
        if(PlayerLevel < 3)
        {
            PlayerLevel++;
            XS += 0.2f;
            YS += 0.2f;
            Debug.Log(PlayerLevel);
            speed -= 1f;
        }
        
    }

    private void flipD(float scale)
    {
        Vector3 characterScale = new(scale*XS,YS,1);
        transform.localScale = characterScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "GameOver")
        {
            FindFirstObjectByType<GameManager>().GameOver();
            PlayerLevel = 0;
            audioControler.playAudiobom();

        }
        else if(other.gameObject.tag == "smaller")
        {
            XS -= 0.2f;
            YS -= 0.2f;
            

        }

        else if(other.gameObject.tag == "Scoring")
        {
            audioControler.playAudiocoin();
            
            FindFirstObjectByType<GameManager>().IncreaseScore();
        }
        else if (other.gameObject.tag == "Level1")
        {
            if(PlayerLevel>1)
            {
                audioControler.playEatSound();

                FindFirstObjectByType<GameManager>().IncreaseScore();
            }
            else
            {
                FindFirstObjectByType<GameManager>().GameOver();
            }
            
        }
        else if (other.gameObject.tag == "level2")
        {
            if (PlayerLevel > 2)
            {
                audioControler.playEatSound();

                FindFirstObjectByType<GameManager>().IncreaseScore();
            }
            else
            {
                FindFirstObjectByType<GameManager>().GameOver();
            }

        }


    }




}
