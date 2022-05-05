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

    private CapsuleCollider cap;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cap = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed*Move,rb.velocity.y);

        if(Input.GetButtonDown("Jump")){
            anim.SetTrigger("isJumping");
            rb.AddForce(new Vector2(rb.velocity.x,jump));
            
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
}
