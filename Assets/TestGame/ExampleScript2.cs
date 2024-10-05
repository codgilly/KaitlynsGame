using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript2 : MonoBehaviour
{
    /*this is a script to learn of refrencing
    refrencing is where you have one script and it will learn of the methods and variables made in the refrenced script

    So you will have to collect the name of the script and place it above the methods like the variables in the other script
    */

    public ExampleScript exampleScript;
    //now that we have refrenced it I will show you how to use it, this is used manily for enemy health script and player damage script

    int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        exampleScript.GetComponent<ExampleScript>();


        if (Input.GetKeyDown("z"))
        {
            //you will have to use the name of the given name for the script then the wanted variable from the other script
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        exampleScript.intNumber2 -= damage;
        //so when z is pressed then the number will go down by the damage value, then for example you can do like "CheckForDead() {if{health =< 0} print("Dead");} and have the method in the update not contained in a if statment
    }
}
