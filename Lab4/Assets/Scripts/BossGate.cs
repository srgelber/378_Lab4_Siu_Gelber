using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BossSystem
{
public class BossGate : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    
    private bool doorOpen = false;
    [SerializeField] private bool top = false;

    private void FixedUpdate() {
        transform.position += (velocity * Time.deltaTime);
    }

    private IEnumerator callChange()
    {
        raise();
        yield return new WaitForSeconds(20);
    }

    void raise()
    {
        if (top)
        {
            velocity.y = 0.5f;
        }

        if (!top)
        {
            velocity.y = -0.1f;
        }
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
