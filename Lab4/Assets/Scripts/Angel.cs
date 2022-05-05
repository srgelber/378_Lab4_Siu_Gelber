using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Angel : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;

    [SerializeField] private bool moving = true;

    void Start()
    {
        StartCoroutine(callChange());
    }
    
    private void FixedUpdate() {
        transform.position += (velocity * Time.deltaTime);
    }

    private IEnumerator callChange()
    {
        while(moving)
        {
            moveLeft();
            yield return new WaitForSeconds(3);
            stop();
            yield return new WaitForSeconds(1);
            moveRight();
            yield return new WaitForSeconds(3);
            stop();
            yield return new WaitForSeconds(1);
        }
    }

    void moveRight()
    {
        velocity.x = 3;
    }

    void stop()
    {
        velocity.x = 0;
    }

    void moveLeft()
    {
        velocity.x = -3;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Death");
        }
    }

}
