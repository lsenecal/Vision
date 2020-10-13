using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MazeBehaviourScript : MonoBehaviour
{
    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        endScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endGame()
    {
        Application.Quit();
    }

    public void restart()
    {
        Console.Write("test");
        SceneManager.LoadScene("Level1-Exploration");
    }
}
