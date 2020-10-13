using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    GameObject player;
    GameObject spawn;
    GameObject audioObject;
    AudioSource aud;
    public GameObject reward;
    public GameObject panneau;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spawn = GameObject.Find("SpawnPoint");
        audioObject = GameObject.Find("WinAudio");     //	votre	GameObject	contenant	l’Audio	source
        aud = audioObject.GetComponent<AudioSource>();
    }

    IEnumerator Fading()
    {
        animator.SetBool("Fade", true);
        yield return new WaitForSeconds(1);
        player.transform.position = spawn.transform.position;
        player.transform.rotation = spawn.transform.rotation;
        animator.SetBool("Fade", false);
    }

    void Move()
    {
        reward.SetActive(true);
        panneau.SetActive(true);
        StartCoroutine(Fading());
        if (aud)
        {
            aud.Play();
        }
    }
}
