using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTestHealth : MonoBehaviour
{
    public int eHealth = 5;

    void Update()
    {
        if (eHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Sword"))
        {
            eHealth--;
        }
    }


}

