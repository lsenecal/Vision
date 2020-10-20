using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animObj : MonoBehaviour
{
    private Animation anim;
    public string animName;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animate()
    {
        anim.Play(animName);
    }
}
