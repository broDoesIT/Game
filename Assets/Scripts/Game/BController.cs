using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BController : MonoBehaviour
{
    AudioController audioControler;
    // Start is called before the first frame update
    void Start()
    {
        audioControler = GameObject.Find("Main Camera").GetComponent<AudioController>();
        speed = Random.Range(5.5f, 9);
    }
    float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
        if (transform.position.y < -6.5f) Destroy(gameObject);
    }
   
}
