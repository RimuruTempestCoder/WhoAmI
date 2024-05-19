using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealKnifeActivator : MonoBehaviour
{
    [SerializeField] KeyStatus llaves;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            llaves.cuchilloEscena = true;
            Destroy(this.gameObject);
        }
    }
}
