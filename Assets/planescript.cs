using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class planescript : MonoBehaviour
{
    public GameObject missile;
    public AudioSource missilesound;
    public Text score;
    public AudioSource explosionsound;
    public GameObject lostscreen;
    public GameObject winscreen;
    void Start()
    {
        lostscreen.SetActive(false);
        winscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        score.text = bullet.myscore.ToString();

        GetComponent<Rigidbody2D>().velocity = Vector2.right * 20;

        if (Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody2D>().velocity = Vector2.up*20;
        else if (Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody2D>().velocity = Vector2.down*20;

        if (Input.GetKeyDown(KeyCode.F))
        {
            shoot();
        }

        if (bullet.exploisioncheck)
        {
            explosionsound.Play();
            bullet.exploisioncheck = false;
        }

        if(GetComponent<Rigidbody2D>().position.x> 410.1)
        {
            winscreen.SetActive(true);
            Destroy(gameObject);
        }

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.y >= 298 & Input.mousePosition.x<395)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 20;
            }
            else if (Input.mousePosition.y < 298 & Input.mousePosition.x < 395)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.down * 20;
            }
        }
    }

    public void shoot()
    {
        Instantiate(missile, transform.position, Quaternion.identity);
        missilesound.Play();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("enemy"))
        {
            lostscreen.SetActive(true);
            Destroy(gameObject);
        }

    }





}
