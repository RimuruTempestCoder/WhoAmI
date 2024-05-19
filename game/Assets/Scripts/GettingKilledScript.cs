using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GettingKilledScript : MonoBehaviour
{
    public string escena;
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(escena, LoadSceneMode.Single);
    }
}
