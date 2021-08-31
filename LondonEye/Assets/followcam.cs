using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class followcam : MonoBehaviour
{
    public Transform Player;
    public float distanceFromObject = 3f;
    void FixedUpdate()
    {
        Vector3 lookOnObject = Player.position - transform.position;
        lookOnObject = Player.position - transform.position;
        transform.forward = lookOnObject.normalized;
        Vector3 playerLastPosition;
        playerLastPosition = Player.position - lookOnObject.normalized * distanceFromObject;
        playerLastPosition.y = Player.position.y + distanceFromObject / 2;
        transform.position = playerLastPosition;
    }

}