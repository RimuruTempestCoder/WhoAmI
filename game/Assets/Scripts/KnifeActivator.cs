using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeActivator : MonoBehaviour
{
    [SerializeField] KeyStatus llaves;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            llaves.llaveDos = true;
            Destroy(this.gameObject);
        }
    }
}
