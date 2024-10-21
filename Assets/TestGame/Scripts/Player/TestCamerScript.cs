using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamerScript : MonoBehaviour
{
    public GameObject camera;
    public GameObject playerObject;

    public float playerPos;
    public float cameraPosX;

    public Vector3 position;
    void Start()
    {
        cameraPosX = camera.transform.position.z;


    }

    // Update is called once per frame
    void Update()
    {

        playerPos = playerObject.transform.position.z;

        position = new Vector3(0, 5, playerPos + 8.25f);

        // Vector3 cameraPosition = new Vector3(playerPos, position);

        camera.transform.localPosition = position;
    }

    //https://www.youtube.com/watch?v=HMuhqNo5PZ8&t=209s video for script, i missed some stuff for the inspector i think
}
