using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillingScript : MonoBehaviour
{
    public AudioSource mySound;
    [SerializeField] KeyStatus llaves;
    public string escena;

    void Start()
    {
        mySound.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && llaves.cuchilloEscena == true)
        {
            mySound.enabled = true;
            mySound.PlayOneShot(mySound.clip);
            StartCoroutine(ChangeSceneAfterSound());
        }
    }

    IEnumerator ChangeSceneAfterSound()
    {
        // Espera hasta que el clip termine
        yield return new WaitForSeconds(mySound.clip.length);
        // Cambia la escena
        SceneManager.LoadScene(escena, LoadSceneMode.Single);
    }
}
