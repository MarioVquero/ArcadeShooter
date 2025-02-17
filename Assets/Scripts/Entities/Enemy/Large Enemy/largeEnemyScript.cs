using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeEnemyScript : Entity
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        moveDown();
    }

    public override void moveDown(int speed)
    {
        base.moveDown();
    }
}
