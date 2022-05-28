using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidbody;
    Transform myTransform;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();
    }


    void Update()
    {
        myRigidbody.velocity = new Vector2(Mathf.Sign(myTransform.localScale.x) * moveSpeed, 0f);
    }

    void OnTriggerExit2D(Collider2D other) {
        FlipEnemyFacing();    
    }

    void FlipEnemyFacing()
    {
        myTransform.localScale = new Vector2(-myTransform.localScale.x, myTransform.localScale.y);
    }
}
