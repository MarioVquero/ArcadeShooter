using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medEnemyScript : Enemy
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    { 
        moveDown(speed);
        
    }

    protected override void moveDown(float speed)
    {
        base.moveDown(speed);
    }
}
