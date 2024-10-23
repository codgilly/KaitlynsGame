using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSwordScript : MonoBehaviour
{
    Animator anim;
    public GameObject sword;
    public bool swinging;

    void Start()
    {
        sword.tag = ("nonAttacking");
        anim = GetComponent<Animator>();
        swinging = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Animator>().enabled = true;
            anim.Play("SwordAnim");
        }

    }

    /*this is basiclly if the sword with collide with any gameObject it will detect it
     so with this we are detecting what is being colideded with it, so with this it will detect the enemy
     if it collides with the enemy then in the console it will print ("hit")

     if it collides with anything else it will do nothing :) 

    if you wanted to be able to detect something else as well like "walls" so the sword reflects off it, that is
    somewhat possible. you can ethier, add "||" like ")|| example.code)" as it means or so if ethier a || b are 
    met then do thing below, 

    or if you want the sword to detect something else happining when colliding basiclly copy and paste the code below 

    so it will be like this below
    */
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Enemy") && swinging == true)
        {
            print("hit");
        }

        /*
        if(col.CompareTag("wall"))
        {
            player.stunned
        }
         */
    }

    public void Swinging()
    {
        sword.tag = ("Sword");
        swinging = true;
    }
    public void SwingingF()
    {
        sword.tag = ("nonAttacking");

    }
    public void StopAttacking()
    {
        gameObject.GetComponent<Animator>().enabled = false;

    }
}
