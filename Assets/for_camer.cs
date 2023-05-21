using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class for_camer : MonoBehaviour
{
    public Transform plane;
    public Transform border;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        border.position = new Vector3(transform.position.x+65, transform.position.y, transform.position.z);

        if (plane == null) return;
        transform.position = new Vector3(plane.position.x+45, transform.position.y, transform.position.z);

        
    }

    public void Restart()
    {
        SceneManager.LoadScene("endExamScene");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("menu_screen");
    }

}
