using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;

    private float Move;
    private Animator anim;
    public Rigidbody rb;

    private int jumpCount = 2;

    private bool facingRight = true;

    public GameObject leftLight;
    public GameObject rightLight;

    private CapsuleCollider cap;

    private AudioSource jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cap = GetComponent<CapsuleCollider>();
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed*Move,rb.velocity.y);

        if(Input.GetButtonDown("Jump") && jumpCount < 2){
            anim.SetTrigger("isJumping");
            jumpSound.Play();
            rb.AddForce(new Vector2(rb.velocity.x,jump));
            jumpCount++;
            
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (facingRight)
            {
                
                facingRight = false;
                transform.Rotate(0f, 180f, 0f);
            }
        }

        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (!facingRight)
            {
                
                transform.Rotate(0f, -180f, 0f);
                facingRight = true;
            }
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            anim.SetBool("isDucking", true);
            //cap.height = 0.2f;
            
            
        }else if(Input.GetKeyUp(KeyCode.DownArrow)){
            anim.SetBool("isDucking", false);
            
            
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision other) {
        jumpCount = 0;
        
    }
}
