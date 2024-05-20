using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SisterGameOver : MonoBehaviour
{
    public string escena;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(escena, LoadSceneMode.Single);
        }
    }
}
