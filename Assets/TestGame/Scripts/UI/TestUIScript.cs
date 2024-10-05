using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 this is a script for the UI and I personaly use it as a level manager

A scene is a "level" so for this I would recomend your game have 3 scenes, a start scene, game scene and a credit scene. 

in the unity project right click and create a "scene" then in the top left in "file" click "build settings" and double click the scene, then click " add scene"  
this now has added this "level" to your game, and this levels are given a value, so the first scene you add will be 0, then next one is 1 and so on.
 */
public class TestUIScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestStartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void TestStartScreen()
    {
        SceneManager.LoadScene(0);
    }

}
