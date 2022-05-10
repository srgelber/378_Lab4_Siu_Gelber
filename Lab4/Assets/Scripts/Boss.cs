using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] private GameObject minionPrefab;

    [SerializeField] private bool moving = true;

    private float speed = 0;

    private float waitTime = 3;

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
            spawnMinion();
            transform.Rotate(0f, 180f, 0f);
            moveLeft();
            yield return new WaitForSeconds(waitTime);
            stop();
            spawnMinion();
            yield return new WaitForSeconds(1);
            transform.Rotate(0f, -180f, 0f);
            moveRight();
            spawnMinion();
            yield return new WaitForSeconds(waitTime);
            stop();
            spawnMinion();
            yield return new WaitForSeconds(1);
        }
    }

    void moveRight()
    {
        velocity.x = 3;
    }

    void stop()
    {
        velocity.x = 0 + speed;
    }

    void moveLeft()
    {
        velocity.x = -3;
    }

    private void spawnMinion()
    {
        GameObject m = Instantiate(minionPrefab) as GameObject;
        m.transform.position = this.transform.position;
    }

}
