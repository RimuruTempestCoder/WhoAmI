using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KillerFollowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;
    void Update()
    {
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);
    }
}
