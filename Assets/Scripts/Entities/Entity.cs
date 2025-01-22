using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{   
    [field: Header("Entity Stats")]
    public int currentHealth;
    public float speed;


    [field: Header("Movenent Settings")]
    public Rigidbody2D rb;
    public Transform transform;
    public Transform pOffset;


    [field: Header("Object References")]
    public GameObject bulletPrefab;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            // Death state here
        } 
    }
}
