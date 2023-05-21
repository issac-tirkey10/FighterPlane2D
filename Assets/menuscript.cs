using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public GameObject instruct_screen;
    void Start()
    {
        instruct_screen.SetActive(false);
    }

    void Update()
    {
        
    }

    public void startgame()
    {
        SceneManager.LoadScene("endExamScene");
    }
    bool t = false;

    public void instruction()
    {
        t = !t;
        instruct_screen.SetActive(t);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    

}
