using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauQuizFinished : MonoBehaviour
{
    public UnlockCatChapterNames unlockMau;
    //tells unlock functions if quiz has been passed

    public void passMauQuiz()
    {
        unlockMau.isMauQuizPassed = true;
        Debug.Log("Mau quiz passed: " + unlockMau.isMauQuizPassed);
    }
}
