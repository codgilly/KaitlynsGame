using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PHealthTest : MonoBehaviour
{
    public Text pHealth;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pHealth.text = health.ToString();
    }
}
