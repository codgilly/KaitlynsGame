using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTest : MonoBehaviour
{
    public NavMeshAgent nav;
    public GameObject player;

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            nav.SetDestination(player.transform.position);
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            nav.SetDestination(player.transform.position);
        }
    }
}
