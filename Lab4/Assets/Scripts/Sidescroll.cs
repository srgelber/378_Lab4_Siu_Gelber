using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidescroll : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;

    void Start()
    {
        this.velocity.x = 1.5f;
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
        }
    }
}
