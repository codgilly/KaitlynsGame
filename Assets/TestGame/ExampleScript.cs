using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*this is a script
 
there are multiple types of scripts, however I belive this should be a simple game you wont likely need to try others however I will explain some-others later

these will be put onto the gameobject this is using.
 */
public class ExampleScript : MonoBehaviour
{
    /*
     there are 3 main types of values. Int - this is a whole number : Float - this is a decimal number : String - this is a combination of anythign like 123Adam456

    a float unfortantly is not fully true to what you set it as, an example is you might set it to 0.5f but actuallty it is 0.50000345

    this script will get a few player inputs and print them in the console.

    to set a value you first have to decalre the type of value you want, so in this example we will do all 3, then we have to name  it, then we can ethier
    A) set it within the script 

    B) Set it depending on the user input

    C) Set it in the Unity project itself
     */
    int intNumber1;
    public int intNumber2;

    float floatFloat1;
    float floatFloat2;

    string string1;
    string string2;



    /*
     this is a method, there are 3 types which are important, a "InBuilt Method" this is where unity has a certain reason for this method

    an example are Awake() - this is where this method is called once and is before the first frame of the game, in perticular this is for setting values made within the script.
     */

    //most lines of code need to finish in a semi colon execpt from methods, when declaring a method you will add (), and when refrencing the method you would do "NameOfMethod();"
    void Awake()
    {
        intNumber1 = 5;
        floatFloat1 = 1.0f; //if you want to have a decimal point then you will have to add an f to the end of the number to further declare it as a float
        string1 = "hello";

        intNumber2 = 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        //as this will not be applied to anyGameObject this is usless, however if it was this is where you would declare your GameComponents
        //so this is where you would write something like chosenNameOfGameComponent = GetComponent<GameComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        //this is where most of the coding will be however you should not add all of the code you want into this as it is poor edicute and makes the game have a harder time running

        //this is an small example of poor edicute

        if (Input.GetKeyDown("q")) //this is how to read what has been pressed, also if you have "getKeyDown" will only read if it has been pressed down, if you remove down then it reads if it being pressed every frame
        {
            intNumber1 ++;
            print(intNumber1);

            //this is poor as when you start adding more to the game it will be horrorable to manage
        }

        //this is a better way to use the void update
        if (Input.GetKeyDown("w"))
        {
            Int1Test();
        }
    }

    //this is another type of method, a player method, this is where it has no inherited function, and you will have to add in said function, so this method will add 1 to int1 and print the result.
    void Int1Test()
    {
        intNumber1 ++;
        print(intNumber1);
    }
}
