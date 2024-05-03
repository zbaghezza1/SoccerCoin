using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Soccer Ball")
        {
            // Activate the game over panel when the player loses
            gameOverPanel.SetActive(true);

        }
        
    }

    public void PlayGames()
    {
        SceneManager.LoadSceneAsync(1);
        RestartGame.Reset();
    }

    public void QuitGames()
    {
        Application.Quit();

    }

}
