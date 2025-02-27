using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Change this to protected virtual
    protected virtual void moveDown(float speed)
    {
        transform.position += new Vector3(speed, 0, 0);
    }
}
