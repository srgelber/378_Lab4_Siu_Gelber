using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BossSystem
{
public class BossBoundary : MonoBehaviour
{
    private BossGate gate;

    void Start()
    {
        gate = GameObject.FindObjectOfType(typeof(BossGate)) as BossGate;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gate.Open();
        }
    }
}
}