using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    Text coinText;
    Text timerText;
    GameObject canvasObj;
    Transform child;
    Transform child2;

    bool tp = false;

    void Start()
    {
        Time.timeScale = 1;
        canvasObj = GameObject.Find("Canvas");
        child = canvasObj.transform.Find("lblCoins");       //le	nom	de	votre	objet	UI	Text
        child2 = canvasObj.transform.Find("lblTime");
        coinText = child.GetComponent<Text>();
        coinText.text = "Coins:	" + GameVariables.currentNbCoins;
        timerText = child2.GetComponent<Text>();
        timerText.text = "Time: " + GameVariables.currentTime.ToString();
        StartCoroutine("TimerTick");
    }

    public void AddCoin()
    {
        GameVariables.currentNbCoins++;
        coinText.text = "Coins:	" + GameVariables.currentNbCoins;
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

            if (GameVariables.currentNbCoins == GameVariables.nbCoins && !tp)
            {
                tp = true;
                GameObject.Find("SpawnPoint").SendMessage("Move");
                //GameObject.Find("World").SendMessage("Stop");
            }

        }
        //	game	over
        if (GameVariables.currentTime <= 0 /*&& GameVariables.currentNbCoins != GameVariables.nbCoins*/)
        {
            SceneManager.LoadScene("Level1-Exploration");
        }
    }
}

