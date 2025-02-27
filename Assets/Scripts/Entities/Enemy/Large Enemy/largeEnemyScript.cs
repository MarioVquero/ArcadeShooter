using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeEnemyScript : Enemy
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        moveDown(speed); // Pass a speed value here
    }

    // Correctly override the moveDown method
    protected override void moveDown(float speed)
    {
        base.moveDown(speed); // Call the base method if needed
        // Add any additional behavior here
    }
}
