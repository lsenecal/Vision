using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIBehaviourLabyrinthe : MonoBehaviour
{
    Text timerText;
    GameObject canvasObj;
    Transform child;
 
    void Start()
    {
        canvasObj = GameObject.Find("Canvas");
        child = canvasObj.transform.Find("lblTime");
        timerText = child.GetComponent<Text>();
        timerText.text = "Time: " + GameVariables.currentTime.ToString();
        StartCoroutine("TimerTick");
    }

    public void Stop()
    {
        StopCoroutine("TimerTick");
    }

    IEnumerator TimerTick()
    {
        while (GameVariables.currentTime > 0)
        {
            //	attendre	une	seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time: " + GameVariables.currentTime.ToString();

        }
        //	game	over
        if (GameVariables.currentTime <= 0 /*&& GameVariables.currentNbCoins != GameVariables.nbCoins*/)
        {
            SceneManager.LoadScene("Level1-Exploration");
        }
    }
}

