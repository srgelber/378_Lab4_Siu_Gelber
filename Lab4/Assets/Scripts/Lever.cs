using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoorSystem
{
public class Lever : MonoBehaviour
{
    private Gate doorObject;

    [SerializeField] private bool inRange = false;

    // Start is called before the first frame update
    void Start()
    {
        doorObject = GameObject.FindObjectOfType(typeof(Gate)) as Gate;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorObject.Open();
            gameObject.SetActive(false);
        }
    }

}

}