using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGunScript : MonoBehaviour
{
    public Camera cam;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //enemy.GameObject.FindGameObjectWithTag("enemy");

        if (enemy.transform.gameObject == null)
        {
            //this is to dubug, if there are no enemys then in the console it will say "no enemy here";
            print("no enemy here");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //with the word down it reads when the button is pressed down 
        //if that is not there then it reads if it is read, so 
        //down happens when button is pressed down, if not there then it cheacks if pressed each fram

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }


    //this basically shoots an invisable line
    //if the thing it shoots has the tag "enemy" then it will do what you want

    public void Shoot()
    {
        RaycastHit rayHit;
        Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.green);

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out rayHit))
        {
            if (rayHit.transform.gameObject.tag == "enemy")
            {
                Destroy(rayHit.transform.gameObject);
            }
        }
    }
}
