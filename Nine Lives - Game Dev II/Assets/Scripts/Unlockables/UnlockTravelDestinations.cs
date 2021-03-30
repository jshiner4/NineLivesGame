using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockTravelDestinations : MonoBehaviour
{
    //unlocks travel destinations when the previous quiz has been passed
    public UnlockCatChapterNames unlockCatNames; // is looking for the bool that comes from this script, but is changed by quiz finished script

    public GameObject travelPage;
    public Button thailand;
    public Button norway;
    public Button russia;
    public Button iran;
    public Button turkey;
    public Button scotland;
    public Button canada;
    public Button america;

    // Update is called once per frame
    void Update()
    {
        if (travelPage.activeSelf)
        {
            if (unlockCatNames.isMauQuizPassed)
            {
                thailand.interactable = true;
            }

            if (unlockCatNames.isSiameseQuizPassed)
            {
                norway.interactable = true;
            }

            if (unlockCatNames.isNorwayQuizPassed)
            {
                russia.interactable = true;
            }

            if (unlockCatNames.isSiberianQuizPassed)
            {
                iran.interactable = true;
            }

            if (unlockCatNames.isPersianQuizPassed)
            {
                turkey.interactable = true;
            }

            if (unlockCatNames.isTurkeyQuizPassed)
            {
                scotland.interactable = true;
            }

            if (unlockCatNames.isScottishQuizPassed)
            {
                canada.interactable = true;
            }

            if (unlockCatNames.isSphynxQuizPassed)
            {
                america.interactable = true;
            }
        }
    }
}
