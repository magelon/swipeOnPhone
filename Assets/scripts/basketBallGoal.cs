using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketBallGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ball")
        {
            Debug.Log("goal!");
        }
    }
}
