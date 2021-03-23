using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockTravelDestinations : MonoBehaviour
{
    public UnlockCatChapterNames unlockCatNames;

    public GameObject travelPage;
    public Button thailand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (travelPage.activeSelf)
        {
            if (unlockCatNames.isMauQuizPassed)
            {
                thailand.interactable = true;
            }
        }
    }
}
