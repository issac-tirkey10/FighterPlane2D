using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    public Transform forcamera;
    private Rigidbody2D missile;
    public GameObject exploisionanime;
    public static float myscore=0;
    public static bool exploisioncheck;

    public float speed = 100f;
    void Start()
    {
        missile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        missile.velocity = new Vector2(1, 0) * speed;
            
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("left"))
        {
            Destroy(gameObject);
        }
        else if (collision.name.StartsWith("enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(exploisionanime, transform.position, Quaternion.identity);
            myscore++;

            exploisioncheck= true;

        }
    }

}
