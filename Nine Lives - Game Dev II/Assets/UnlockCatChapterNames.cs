using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockCatChapterNames : MonoBehaviour
{
    public GameObject tableOfContents;
    public GameObject mauMask;

    public bool isMauQuizPassed;
    // Start is called before the first frame update
    void Start()
    {
        isMauQuizPassed = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if (tableOfContents.activeSelf)
        {
            Debug.Log("table of contents active");
            if (isMauQuizPassed)
            {
                UnlockEgyptianMauTitle();
                Debug.Log("unlocked Mau Chapter name");
            }
        }
    }

    public void UnlockEgyptianMauTitle()
    {
        mauMask.SetActive(false);
    }
}
