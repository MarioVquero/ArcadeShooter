using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medEnemyScript : Enemy
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        StartCoroutine(shootBullet());
    }

    // Update is called once per frame
    void Update()
    { 
        moveDown(speed);
        // Debug.Log("pew pew");
    }

    protected override void moveDown(float speed)
    {
        base.moveDown(speed);
    }

    protected override IEnumerator shootBullet()
    {
        yield return base.shootBullet();
    }
}
