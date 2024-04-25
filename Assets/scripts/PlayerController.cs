using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   
   public AudioSource scaleSource;
   public AudioClip [] scaleClip;


    public float moveSpeed;

    float xInput;
    float yInput;

    Rigidbody rb;

    int coinsCollected;
   

    public GameObject WinText;

    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
       
       scaleClip = Resources.LoadAll<AudioClip>("Scale");
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
    //private void Awake()
   // {
      //  audioClips = Resources.LoadAll<AudioClip>("Scale");
    //}
    private void FixedUpdate()
    {
        rb.AddForce(xInput * moveSpeed,0, yInput * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin" )
        {
            coinsCollected++;
            other.gameObject.SetActive(false);

            scaleSource.clip = scaleClip[0];
            scaleSource.Play();
   

        }

        if (coinsCollected >=9)
        {
            WinText.SetActive(true);
        }
    }
}
