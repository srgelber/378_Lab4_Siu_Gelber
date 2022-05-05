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
}
