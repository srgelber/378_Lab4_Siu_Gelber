using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
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
            yield return new WaitForSeconds(6);
            this.gameObject.SetActive(false);
        }
    }

    void moveRight()
    {
        velocity.x = -6;
    }

    void stop()
    {
        velocity.x = 0;
    }

    void moveLeft()
    {
        velocity.x = -6;
    }
}
