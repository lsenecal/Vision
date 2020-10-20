using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject character;
    public GameObject respawn;

    private void OnTriggerEnter()
    {
        character.transform.position = respawn.transform.position;
        character.transform.rotation = respawn.transform.rotation;
    }
}
