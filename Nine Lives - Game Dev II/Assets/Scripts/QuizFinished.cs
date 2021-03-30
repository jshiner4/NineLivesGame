using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizFinished : MonoBehaviour
{
    public UnlockCatChapterNames unlockCat; // a bool
    //tells unlock functions if quiz has been passed

    public void PassedMauQuiz()
    {
        unlockCat.isMauQuizPassed = true;
        Debug.Log("Mau quiz passed: " + unlockCat.isMauQuizPassed);
    }

    public void PassedSiameseQuiz()
    {
        unlockCat.isSiameseQuizPassed = true;
    }

    public void PassedNorwayQuiz()
    {
        unlockCat.isNorwayQuizPassed = true;
    }

    public void PassedSiberianQuiz()
    {
        unlockCat.isSiberianQuizPassed = true;
    }

    public void PassedPersianQuiz()
    {
        unlockCat.isPersianQuizPassed = true;
    }

    public void PassedTurkishQuiz()
    {
        unlockCat.isTurkeyQuizPassed = true;
    }

    public void PassedScottishQuiz()
    {
        unlockCat.isScottishQuizPassed = true;
    }

    public void PassedSphynxQuiz()
    {
        unlockCat.isSphynxQuizPassed = true;
    }

    public void PassedMaineQuiz()
    {
        unlockCat.isMaineQuizPassed = true;
    }
}
