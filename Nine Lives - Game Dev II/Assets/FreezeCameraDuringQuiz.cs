using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeCameraDuringQuiz : MonoBehaviour
{
    public bool isTakingQuiz;

    //freezes camera during quiz so it's not annoying
    void Start()
    {
        isTakingQuiz = false;
    }

    public void StartQuiz()
    {
        isTakingQuiz = true;
        Debug.Log("player is taking quiz");
    }

    public void EndQuiz()
    {
        isTakingQuiz = false;
        Debug.Log("player is no longer taking quiz");
    }
}
