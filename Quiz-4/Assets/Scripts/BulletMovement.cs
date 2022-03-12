using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    //In this function only bullet is going forward why player instantiate the bullets
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x,transform.position.y +10f*Time.deltaTime);
        if (transform.position.y > 25)
        {
            Destroy(gameObject);
        }
    }
}
