using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Quaternion initialRotation;
    public Quaternion finalRotation = Quaternion.Euler(new Vector3(0, -120f, 0));
    private float rotationSpeed = 3.0f;
    [SerializeField] KeyStatus llaves;
    public GameObject doorOpener;
    private bool hasOpened = false; 
    
    void Start()
    {
        if (doorOpener != null)
        {
            initialRotation = doorOpener.transform.rotation;
        }
        else
        {
            Debug.LogError("doorOpener no está asignado en el Inspector.");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (!hasOpened && llaves.llaveUno == true)
        {
            if (doorOpener != null)
            {
                hasOpened = true; 
                StartCoroutine(RotateObject(initialRotation, finalRotation));
            }
            else
            {
                Debug.LogError("doorOpener no está asignado en el Inspector.");
            }
        }
        else if (llaves.llaveUno != true)
        {
            Debug.Log("No tienes la llave.");
        }else{
            Destroy(this.gameObject);
        }
    }

    IEnumerator RotateObject(Quaternion fromRotation, Quaternion toRotation)
    {
        float elapsedTime = 0.0f;
        while (elapsedTime < 1.0f)
        {
            elapsedTime += Time.deltaTime * rotationSpeed;
            doorOpener.transform.rotation = Quaternion.Lerp(fromRotation, toRotation, elapsedTime);
            yield return null;
        }
        doorOpener.transform.rotation = toRotation; 
    }
}
