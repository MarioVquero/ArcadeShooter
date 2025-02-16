using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : Entity
{

    public Vector3 moveDirec;
    

    public GameManagerScript gameManagerScript;

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Pmovement();
        
    }

    
    // player movement here
    public void Pmovement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        moveDirec = new Vector3(x, y, 0);
        transform.Translate(moveDirec * Time.deltaTime * speed);
    }
}
