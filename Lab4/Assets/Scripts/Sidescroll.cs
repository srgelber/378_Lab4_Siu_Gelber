using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidescroll : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] AudioSource bgm;
    [SerializeField] AudioSource bossTheme;

    void Start()
    {
        this.velocity.x = 3.5f;
    }
    
    void FixedUpdate()
    {
        transform.position += (velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boss Boundary")
        {
            this.velocity.x = 0f;
            bgm.Stop();
            bossTheme.Play();
        }

        if (other.tag == "Vertical")
        {
            this.velocity.x = 0f;
            this.velocity.y = 3.5f;
        }

        if (other.tag == "Horizontal")
        {
            this.velocity.x = 3.5f;
            this.velocity.y = 0f;
        }
    }
}
