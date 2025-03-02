using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : Entity
{
    // Start is called before the first frame update
    [field: SerializeField] public List<Transform> bulletSpawnPoints {get; private set;}
    private bool isShooting = true;
    
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
        // Debug.Log(transform.forward * speed );
        rb.AddRelativeForce(Vector2.left * speed);
    }


    protected virtual IEnumerator shootBullet()
    {
        while (isShooting)
        {
            int count = bulletSpawnPoints.Count;
            for(int i = 0; i < count; i++)
            {
                Debug.Log(i);
                Quaternion rotation = quaternion.Euler(0,0,45 * i);

                Instantiate(bulletPrefab, bulletSpawnPoints[i].transform.position, rotation);
            
            }
            yield return new WaitForSeconds(1f);
        }
        
    }
}
