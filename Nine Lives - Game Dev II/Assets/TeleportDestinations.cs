using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDestinations : MonoBehaviour
{
    public GameObject player;
    public Transform egypt;

    //this script is used to teleport the player to each destination. 

    public void teleportEgypt()
    {
        player.transform.position = egypt.position;
    }
}
