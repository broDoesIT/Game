using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishRightSpawner : MonoBehaviour
{
    public GameObject[] Fish;
    float T = 7f;
    float timeCountDown1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(Fish[Random.Range(0, Fish.Length)], new Vector2(11.5f, Random.Range(-3.6f, 3.6f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timeCountDown1 += Time.deltaTime;
        if (timeCountDown1 > T)
        {
            T += 0.5f;
            Instantiate(Fish[Random.Range(0, Fish.Length)], new Vector2(11.5f, Random.Range(-3.6f, 3.6f)), Quaternion.identity);
            timeCountDown1 = 0;
        }
    }
}
