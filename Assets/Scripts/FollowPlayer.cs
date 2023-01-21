using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 5, -7);
    public Vector3 cameraFpvOffset = new Vector3(0, 4, -1);
    public bool cameraSwitcherFPV = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") == true)
        {
            if (cameraSwitcherFPV == true)
            {
                cameraSwitcherFPV = false;
            } else
            {
                cameraSwitcherFPV = true;
            }
        }
        if (cameraSwitcherFPV == false)
        {
            // Set the camera position based on the player position in combination with the camera offset
            transform.position = player.transform.position + cameraOffset;
        } else
        {
            transform.position = player.transform.position + cameraFpvOffset;
        }

    }
}
