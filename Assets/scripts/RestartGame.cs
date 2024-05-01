using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private CountScore countScore;

    // Start is called before the first frame update
    void Start()
    {
        countScore = FindAnyObjectByType<CountScore>();
    }


    public static void Reset()
    {
        Time.timeScale = 1;
        CountScore.scoreCount = 0;
    }
}
