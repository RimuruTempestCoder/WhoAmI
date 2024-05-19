using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillingScript : MonoBehaviour
{
    public AudioSource mySound;
    [SerializeField] KeyStatus llaves;
    public string escena;
    public GameObject objectToHide; 

    void Start()
    {
        mySound.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && llaves.cuchilloEscena == true)
        {
            if (objectToHide != null)
            {
                Renderer[] renderers = objectToHide.GetComponentsInChildren<Renderer>();
                foreach (Renderer renderer in renderers)
                {
                    renderer.enabled = false;
                }
            }
            mySound.enabled = true;
            mySound.PlayOneShot(mySound.clip);
            
            StartCoroutine(ChangeSceneAfterSound());
        }
    }

    void OnTriggerExit()
    {
        SceneManager.LoadScene(escena, LoadSceneMode.Single);
    }

    IEnumerator ChangeSceneAfterSound()
    {
        yield return new WaitForSeconds(mySound.clip.length);
    }
}
