using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D RB2D;
    public float bulletSpeed = 5f;
    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveBullet();
    }

    private void moveBullet()
    {
        RB2D.AddRelativeForce(Vector2.left * bulletSpeed);
    }

    
}
