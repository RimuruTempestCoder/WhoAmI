using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    public Text text;
    public string textToShow;
    void Start()
    {
        text.gameObject.SetActive(false); 
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true); 
            text.text = textToShow; 
            StartCoroutine(HideTextAfterDelay(5.0f)); 
        }
    }

    IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); 
        text.gameObject.SetActive(false); 
    }
}
