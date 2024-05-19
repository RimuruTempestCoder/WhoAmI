using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KnifeSceneChanger : MonoBehaviour
{
    [SerializeField] KeyStatus llaves;
    public string escena;
   void OnTriggerEnter(Collider collider)
    {
        if(llaves.llaveDos == true)
        {
            SceneManager.LoadScene(escena, LoadSceneMode.Single);
        }
    }
}
