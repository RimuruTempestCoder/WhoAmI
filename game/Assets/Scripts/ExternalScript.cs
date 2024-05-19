using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalScript : MonoBehaviour
{
    public bool hasKey = false; // Variable pública para indicar si se recogió la llave

    public void OnPickUpKey()
    {
        Debug.Log("Recogió la llave"); // Opcional: Realiza la acción deseada cuando el jugador recoge la llave
        hasKey = true; // Establece la variable hasKey en true
    }
}
