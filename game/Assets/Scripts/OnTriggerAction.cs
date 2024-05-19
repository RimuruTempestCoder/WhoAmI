using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerAction : MonoBehaviour
{
    public GameObject malo;
    public float duration;

    public Vector3 targetPosition; 

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Trigger");
            StartCoroutine(MoveAndDeactivate());
        }
    }

    IEnumerator MoveAndDeactivate()
    {
        Vector3 startPosition = malo.transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            malo.transform.position = Vector3.Lerp(startPosition, targetPosition, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        malo.transform.position = targetPosition;
        malo.SetActive(false);
    }
}
