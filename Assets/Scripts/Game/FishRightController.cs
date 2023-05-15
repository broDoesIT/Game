using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishRightController : MonoBehaviour
{
    float T = 3f;
    float timeCountDown = 0;
    void Start()
    {

        speed = Random.Range(0.5f, 3);
    }
    float speed;
    // Update is called once per frame
    void Update()
    {
        timeCountDown *= Time.deltaTime;
        if (timeCountDown > T)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x < -11.5f) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }

    }
}
