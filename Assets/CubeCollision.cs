using Leap.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float BallSpeed;


    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - BallSpeed);
        if (gameObject.transform.position.z < -0.8)
        {
            Destroy(gameObject);
            if (!EndScript.gameOver)
                ScoreScript.scoreValue += 1;
        }
    }

    public bool isTouching(Collider other)
    {
        if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
            return true;
        else return false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (isTouching(other))
        {
            Destroy(gameObject);
            LivesScript.LostLife();
        }
    }
}
