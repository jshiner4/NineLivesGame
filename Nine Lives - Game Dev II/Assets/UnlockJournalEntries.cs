using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockJournalEntries : MonoBehaviour
{
    public UnlockCatChapterNames unlockCatNames;

    public GameObject mauEntry;
    public GameObject mauMasks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
    }

}
