using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketBallGoal : MonoBehaviour
{
    public GameObject win;
    private ParticleSystem p;
    private void Start()
    {
        p = win.GetComponent<ParticleSystem>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ball")
        {
            Debug.Log("goal!");
            if (!p.isPlaying)
            {
                p.Play();
            }

        }
    }
}
