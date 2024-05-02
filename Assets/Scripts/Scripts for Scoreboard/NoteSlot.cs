using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NoteSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;
    [SerializeField] private AudioSource noteSound;
    public GameObject noteName;
    public void Placed()
    {
        //noteName.SetActive(true);
        noteSound.Play();
        Invoke("ChangeScene", 2.0f); //set to 5.0f (5 seconds before action)
    }

    public void ChangeScene() //change scene to next level
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else //if last note, quit
        {
            Application.Quit();
        }
            
    }
}
