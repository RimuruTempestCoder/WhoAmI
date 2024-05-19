using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnTrigger : MonoBehaviour
{
    public AudioSource mySound;
    private bool hasSounded;

    void Start()
    {
        mySound.enabled = false;
        hasSounded = false;
    }
   void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player") && hasSounded == false)
        {
            mySound.enabled = true;
            mySound.PlayOneShot(mySound.clip);
            hasSounded = true;
        }
    }
}
