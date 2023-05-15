using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnController : MonoBehaviour
{
    public GameObject[] GoldCoin;
    float TC = 3f,TB = 15f;
    float timeCountDown1 = 0;
    float timeCountDown2 = 0;
    float timeCountB = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(GoldCoin[0], new Vector2(Random.Range(-10.5f, 8.5f), Random.Range(6.5f, 10.5f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timeCountDown1 += Time.deltaTime;
        timeCountDown2 += Time.deltaTime;
        timeCountB += Time.deltaTime;
        if(timeCountDown1 >=TC)
        {
            Instantiate(GoldCoin[0], new Vector2(Random.Range(-10.5f,8.5f), Random.Range(6.5f, 10.5f)), Quaternion.identity);
            timeCountDown1 = 0;
        }
        if(timeCountDown2 >= 90) 
        {
            TC += 1f;
            timeCountDown2 = 0;
            timeCountB -= 1f;
        }
        if(timeCountB>=TB)
        {
            Instantiate(GoldCoin[1], new Vector2(Random.Range(-10.5f, 8.5f), Random.Range(6.5f, 10.5f)), Quaternion.identity);
            timeCountB = 0;
        }
    }
}
