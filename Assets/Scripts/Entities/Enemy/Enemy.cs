using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : Entity
{
    // Start is called before the first frame update
    [field: SerializeField] public List<Transform> bulletSpawnPoints {get; private set;}

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

    protected virtual void shoot()
    {
        int count = bulletSpawnPoints.Count;
        for(int i = 0; i < count; i++)
        {
            Instantiate(bulletPrefab, bulletSpawnPoints[i].transform.position, quaternion.identity);
        }
    }
}
