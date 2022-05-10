using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlat : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;

    [SerializeField] private int direction = 0;

    void Start()
    {
        StartCoroutine(callChange());

    }
    
    private void FixedUpdate() {
        transform.position += (velocity * Time.deltaTime);
    }

    private IEnumerator callChange()
    {
        while(direction == 0)
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

        while(direction == 1)
        {
            moveRight();
            yield return new WaitForSeconds(3);
            stop();
            yield return new WaitForSeconds(1);
            moveLeft();
            yield return new WaitForSeconds(3);
            stop();
            yield return new WaitForSeconds(1);
        }
    }

    void moveRight()
    {
        velocity.x = 2;
    }

    void stop()
    {
        velocity.x = 0;
    }

    void moveLeft()
    {
        velocity.x = -2;
    }

}
