using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockJournalEntries : MonoBehaviour
{
    public UnlockCatChapterNames unlockCatNames;
    // yes i am aware this is a stupid, unnecessary way to do it. im tired
    public GameObject mauEntry;
    public GameObject mauMasks;

    public GameObject siamEntry;
    public GameObject siamMasks;

    public GameObject norwayEntry;
    public GameObject norwayMasks;

    public GameObject siberianEntry;
    public GameObject siberianMasks;

    public GameObject persianEntry;
    public GameObject persianMasks;

    public GameObject turkeyEntry;
    public GameObject turkeyMasks;

    public GameObject scottishEntry;
    public GameObject scottishMasks;

    public GameObject sphynxEntry;
    public GameObject sphynxMasks;

    public GameObject maineEntry;
    public GameObject maineMasks;

    // if the quiz has been passed and the bool is true, remove the masks from the corresponding journal entry once opened.
    void Update()
    {
        if (mauEntry.activeSelf)
        {
            if (unlockCatNames.isMauQuizPassed)
            {
                mauMasks.SetActive(false);
                Debug.Log("mau journal entry masks turned off");
            }
        }

        if (siamEntry.activeSelf)
        {
            if (unlockCatNames.isSiameseQuizPassed)
            {
                siamMasks.SetActive(false);
                Debug.Log("siam journal entry masks turned off");
            }
        }

        if (norwayEntry.activeSelf)
        {
            if (unlockCatNames.isNorwayQuizPassed)
            {
                norwayMasks.SetActive(false);
                Debug.Log("forest cat journal entry masks turned off");
            }
        }

        if (siberianEntry.activeSelf)
        {
            if (unlockCatNames.isSiberianQuizPassed)
            {
                siberianMasks.SetActive(false);
                Debug.Log("siberian journal entry masks turned off");
            }
        }

        if (persianEntry.activeSelf)
        {
            if (unlockCatNames.isPersianQuizPassed)
            {
                persianMasks.SetActive(false);
                Debug.Log("persian journal entry masks turned off");
            }
        }

        if (turkeyEntry.activeSelf)
        {
            if (unlockCatNames.isTurkeyQuizPassed)
            {
                turkeyMasks.SetActive(false);
                Debug.Log("turkish angora journal entry masks turned off");
            }
        }

        if (scottishEntry.activeSelf)
        {
            if (unlockCatNames.isScottishQuizPassed)
            {
                scottishMasks.SetActive(false);
                Debug.Log("scottish fold journal entry masks turned off");
            }
        }

        if (sphynxEntry.activeSelf)
        {
            if (unlockCatNames.isSphynxQuizPassed)
            {
                sphynxMasks.SetActive(false);
                Debug.Log("sphynx journal entry masks turned off");
            }
        }

        if (maineEntry.activeSelf)
        {
            if (unlockCatNames.isMaineQuizPassed)
            {
                maineMasks.SetActive(false);
                Debug.Log("maine coon journal entry masks turned off");
            }
        }
    }

}
