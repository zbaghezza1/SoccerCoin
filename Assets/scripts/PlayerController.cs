using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   
   [SerializeField]  AudioSource coinSound;
   [SerializeField]  AudioClip[] scaleClip;


    public float moveSpeed;

    float xInput;
    float yInput;

    Rigidbody rb;

    int coinsCollected;
 

    public GameObject WinText;
    public GameObject Sound;

    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
        coinSound.clip = scaleClip[0];

    }

    // Update is called once per frame
    void Update()
    {
        xInput=Input.GetAxis("Horizontal");
        yInput=Input.GetAxis("Vertical");

        if (transform.position.y <=-5f)
        {
            SceneManager.LoadScene(0);
        }

    }
   
    private void FixedUpdate()
    {
        rb.AddForce(xInput * moveSpeed,0, yInput * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinsCollected++;
            other.gameObject.SetActive(false);


            coinSound.PlayOneShot(scaleClip[coinsCollected-1]);

        }

        if (coinsCollected >=9)
        {
            WinText.SetActive(true);
        }
    }
}
