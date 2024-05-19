using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKeyActivator : MonoBehaviour
{
    [SerializeField] KeyStatus llaves;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            llaves.llaveUno = true;
            Destroy(this.gameObject);
        }
    }
}
