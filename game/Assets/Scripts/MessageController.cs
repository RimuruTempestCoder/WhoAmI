using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    public Text text;
    public string textToShow;
    public AudioSource mySound;
    void Start()
    {
        text.gameObject.SetActive(false); 
        mySound.enabled = false;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true); 
            text.text = textToShow; 
            mySound.enabled = true;
            mySound.PlayOneShot(mySound.clip);
            StartCoroutine(HideTextAfterDelay(5.0f)); 
        }
    }

    IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); 
        text.gameObject.SetActive(false); 
    }
}
