using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("r"))
        {
            RespawnPlayer();
        }
    }

    private void RespawnPlayer()
    {
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1f, player.transform.position.z);
        player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
