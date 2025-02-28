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
        shoot();
    }

    protected override void moveDown(float speed)
    {
        base.moveDown(speed);
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
