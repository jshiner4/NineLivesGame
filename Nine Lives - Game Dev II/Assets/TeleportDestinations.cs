using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDestinations : MonoBehaviour
{
    public GameObject player;
    public Transform egypt;
    public CharacterController controller;

    //this script is used to teleport the player to each destination. 

    public void TeleportEgypt()
    {
        controller.enabled = false;
        player.transform.position = egypt.position;
        controller.enabled = true;
    }
}
