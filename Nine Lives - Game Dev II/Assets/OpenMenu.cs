using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject menu;
    // opens and closes the ingame menu. 

    // this stops the mouse from controlling the camera when in the menu
    public bool isMenuOpen;

    private void Start()
    {
        menu.SetActive(false);
        isMenuOpen = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu.activeInHierarchy)
            {
                isMenuOpen = false;
                menu.SetActive(false);
            }
            else
            {
                isMenuOpen = true;
                menu.SetActive(true);
            }
        }
    }
}
