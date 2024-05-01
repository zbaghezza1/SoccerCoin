using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource myFx;

    public void ClickSound()
    {
        myFx.Play();
    }
}
