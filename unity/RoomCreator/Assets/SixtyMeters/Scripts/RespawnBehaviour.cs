using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBehaviour : MonoBehaviour
{

    Vector3 spawnPosition = new Vector3(0, 100, 0);
    float respawnThreshold = -100;

    // Start is called before the first frame update
    void Start()
    {
        DebugHelper.Instance.Log("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < respawnThreshold){
            var player = GetComponentInChildren<OVRPlayerController>();
            player.enabled = false;
            transform.position = spawnPosition;
            player.enabled = true;
        }
        DebugHelper.Instance.Log("Debug: "+transform.position);
    }
}
