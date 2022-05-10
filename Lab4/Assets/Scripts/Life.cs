using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] AudioSource damageSound;

    private bool invincibility = false;

    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;
    
    void Start()
    {

    }

    private IEnumerator callChange()
    {
        invincibility = true;
        health -= 1;
        damageSound.Play();

        if (health == 2)
        {
            heart3.SetActive(false);
        }

        if (health == 1)
        {
            heart2.SetActive(false);
        }
        
        if (health <= 0)
        {
            heart1.SetActive(false);
            die();
        }
       yield return new WaitForSeconds(2);
       invincibility = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Angel" || other.tag == "Boss")
        {
            if (!invincibility)
            {
            StartCoroutine(callChange());
            }
        }
    }

    private void die()
    {
        SceneManager.LoadScene("Death");
    }
}
