using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{   
    [field: Header("Entity Stats")]
    public int HP;
    public float speed;


    [field: Header("Movenent Settings")]
    public Rigidbody rb;
    public Transform transform;
    public Transform pOffset;


    [field: Header("Object References")]

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
