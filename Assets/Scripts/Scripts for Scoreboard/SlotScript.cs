using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour
{
    
    [SerializeField] private AudioSource noteSound;
    public void Placed()
    {
        noteSound.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
    }
    
}
