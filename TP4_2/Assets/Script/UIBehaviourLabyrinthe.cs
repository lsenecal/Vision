using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIBehaviourLabyrinthe : MonoBehaviour
{
    void Start()
    {
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
        }
        //	game	over
        if (GameVariables.currentTime <= 0 /*&& GameVariables.currentNbCoins != GameVariables.nbCoins*/)
        {
            SceneManager.LoadScene("Labyrinthe");
        }
    }
}

