using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public GameObject[] Fish1;
    float T = 7f;
    float timeCountDown1 = 0;
    float timeCountShark = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Fish1[Random.Range(0, Fish1.Length - 1)],new Vector2(-11.5f,Random.Range(-3.6f,3.6f)),Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCountDown1 += Time.deltaTime;
        timeCountShark += Time.deltaTime;
        if(timeCountDown1 > T)
        {
            Instantiate(Fish1[Random.Range(0, Fish1.Length - 1)], new Vector2(-11.5f, Random.Range(-3.6f, 3.6f)), Quaternion.identity);
            
            timeCountDown1 = 0;
        }
        if(timeCountShark > 30)
        {
            Instantiate(Fish1[6], new Vector2(-11.5f, Random.Range(-3.6f, 3.6f)), Quaternion.identity);
            timeCountShark = 0;
        }
    }
}
