using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDestinations : MonoBehaviour
{
    public GameObject player;
    public CharacterController controller;

    public Transform egypt;
    public Transform thailand;
    public Transform norway;
    public Transform russia;
    public Transform iran;
    public Transform turkey;
    public Transform scotland;
    public Transform canada;
    public Transform america;

    //this script is used to teleport the player to each destination. 

    public void TeleportEgypt()
    {
        controller.enabled = false;
        player.transform.position = egypt.position;
        controller.enabled = true;
    }

    public void TeleportThailand()
    {
        controller.enabled = false;
        player.transform.position = thailand.position;
        controller.enabled = true;
    }

    public void TeleportNorway()
    {
        controller.enabled = false;
        player.transform.position = norway.position;
        controller.enabled = true;
    }

    public void TeleportRussia()
    {
        controller.enabled = false;
        player.transform.position = russia.position;
        controller.enabled = true;
    }

    public void TeleportIran()
    {
        controller.enabled = false;
        player.transform.position = iran.position;
        controller.enabled = true;
    }

    public void TeleportTurkey()
    {
        controller.enabled = false;
        player.transform.position = turkey.position;
        controller.enabled = true;
    }

    public void TeleportScotland()
    {
        controller.enabled = false;
        player.transform.position = scotland.position;
        controller.enabled = true;
    }

    public void TeleportCanada()
    {
        controller.enabled = false;
        player.transform.position = canada.position;
        controller.enabled = true;
    }

    public void TeleportAmerica()
    {
        controller.enabled = false;
        player.transform.position = america.position;
        controller.enabled = true;
    }

}
