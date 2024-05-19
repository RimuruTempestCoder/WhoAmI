using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BrotherDoorScript : MonoBehaviour
{
    [SerializeField] KeyStatus llaves;
    public string escena;
    void OnTriggerEnter(Collider collider)
    {
        if (llaves.llaveUno == true && llaves.llaveDos == true && llaves.cuchilloEscena == true) 
        {
            SceneManager.LoadScene(escena, LoadSceneMode.Single);
        }
    }
}
