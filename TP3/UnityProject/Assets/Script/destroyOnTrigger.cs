using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnTrigger : MonoBehaviour
{
    public GameObject fx;
    GameObject worldObject;
    GameObject audioObject;
    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("World");
        audioObject = GameObject.Find("Audio");     //	votre	GameObject	contenant	l’Audio	source
        aud = audioObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        //	OnCollisionEnter	
        worldObject.SendMessage("AddCoin");
        if (aud)
        {
            aud.Play();
        }
        Instantiate(fx, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Rotate(new Vector3(45, 0, 30) * Time.deltaTime);
    }
}
