using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    AudioController audioControler;
    // Start is called before the first frame update
    void Start()
    {
        audioControler = GameObject.Find("Main Camera").GetComponent<AudioController>();
        speed = Random.Range(0.5f, 2);
    }
    float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
        if (transform.position.y < -6.5f) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            
        }
        
    }
}
