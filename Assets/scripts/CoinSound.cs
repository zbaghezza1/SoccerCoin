using UnityEngine;

public class CoinNotePlay : MonoBehaviour
{
    public AudioSource CoinSound;

    private void OnCollisionEnter(Collision collision)
    {
        CoinSound.Play();
    }
}
