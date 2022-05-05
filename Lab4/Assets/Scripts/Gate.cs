using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoorSystem
{
public class Gate : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    
    private bool doorOpen = false;

    private void FixedUpdate() {
        transform.position += (velocity * Time.deltaTime);
    }

    private IEnumerator callChange()
    {
        raise();
        yield return new WaitForSeconds(2);
        stop();
    }

    void raise()
    {
        velocity.y = 1;
    }

    void stop()
    {
        velocity.y = 0;
    }

    public void Open()
    {
        if (!doorOpen)
        {
            StartCoroutine(callChange());
        }
    }
}

}