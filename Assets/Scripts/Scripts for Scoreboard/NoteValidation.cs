using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteValidation : MonoBehaviour
{
    public GameObject PianoNotes;
    public SpriteRenderer Renderer;
    [SerializeField] private AudioSource noteSound;
    //public GameObject noteName;

   // bool
    public void Placed()
    {
        if (PianoNotes)//noteName.SetActive(true);
            noteSound.Play();
        Invoke("ChangeScene", 2.0f); //set to 5.0f (5 seconds before action)
    }



}
