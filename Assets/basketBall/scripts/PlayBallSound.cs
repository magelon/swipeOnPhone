using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBallSound : MonoBehaviour
{
    AudioSource au;
    private void Start()
    {
        au = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        au.Play(0);   
    }
}
