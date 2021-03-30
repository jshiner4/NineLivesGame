using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockCatChapterNames : MonoBehaviour
{
    /// <summary>
    /// unlocks the associated cat name when quiz is passed
    /// </summary>
    public GameObject tableOfContents;
    public GameObject mauMask; // use array/tags? 
    public GameObject siamMask;
    public GameObject norwayMask;
    public GameObject siberianMask;
    public GameObject persianMask;
    public GameObject turkeyMask;
    public GameObject scottishMask;
    public GameObject sphynxMask;
    public GameObject maineMask;

    public bool isMauQuizPassed;
    public bool isSiameseQuizPassed;
    public bool isNorwayQuizPassed;
    public bool isSiberianQuizPassed;
    public bool isPersianQuizPassed;
    public bool isTurkeyQuizPassed;
    public bool isScottishQuizPassed;
    public bool isSphynxQuizPassed;
    public bool isMaineQuizPassed;
    //yes, i could have done this a smarter way, i know. it was tiny brain hours.

    void Start()
    {
        isMauQuizPassed = false;
        isSiameseQuizPassed = false;
        isNorwayQuizPassed = false;
        isSiberianQuizPassed = false;
        isPersianQuizPassed = false;
        isTurkeyQuizPassed = false;
        isScottishQuizPassed = false;
        isSphynxQuizPassed = false;
        isMaineQuizPassed = false;
    }

        // once specific quiz is passed, removes masks from corresponding entry
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

            if (isSiameseQuizPassed)
            {
                UnlockSiameseTitle();
            }

            if (isNorwayQuizPassed)
            {
                UnlockNorwayTitle();
            }

            if (isSiberianQuizPassed)
            {
                UnlockSiberianTitle();
            }

            if (isPersianQuizPassed)
            {
                UnlockPersianTitle();
            }

            if (isTurkeyQuizPassed)
            {
                UnlockTurkishTitle();
            }

            if (isScottishQuizPassed)
            {
                UnlockScottishTitle();
            }

            if(isSphynxQuizPassed)
            {
                UnlockSphynxTitle();
            }

            if (isMaineQuizPassed)
            {
                UnlockMaineTitle();
            }
        }
    }

    public void UnlockEgyptianMauTitle()
    {
        mauMask.SetActive(false);
    }

    public void UnlockSiameseTitle()
    {
        siamMask.SetActive(false);
    }

    public void UnlockNorwayTitle()
    {
        norwayMask.SetActive(false);
    }

    public void UnlockSiberianTitle()
    {
        siberianMask.SetActive(false);
    }

    public void UnlockPersianTitle()
    {
        persianMask.SetActive(false);
    }

    public void UnlockTurkishTitle()
    {
        turkeyMask.SetActive(false);
    }

    public void UnlockScottishTitle()
    {
        scottishMask.SetActive(false);
    }

    public void UnlockSphynxTitle()
    {
        sphynxMask.SetActive(false);
    }

    public void UnlockMaineTitle()
    {
        maineMask.SetActive(false);
    }
}
