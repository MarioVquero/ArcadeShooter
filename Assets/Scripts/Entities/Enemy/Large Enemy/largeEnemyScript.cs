using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
        shoot();
    }

    // Correctly override the moveDown method
    protected override void moveDown(float speed)
    {
        base.moveDown(speed); // Call the base method if needed
        // Add any additional behavior here
    }

    protected override void shoot()
    {
        base.shoot();
        // int count = this.bulletSpawnPoints.Count;
        // for(int i = 0; i < count; i++)
        // {
        //     Instantiate(bulletPrefab, this.bulletSpawnPoints[i].transform.position, quaternion.RotateZ(90));
        // }
    }
}
