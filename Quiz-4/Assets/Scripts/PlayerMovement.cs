using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position.x<10)
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + movementspeed * Time.deltaTime, transform.position.y);
        }
        if (transform.position.x > -10)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector2(transform.position.x - movementspeed * Time.deltaTime, transform.position.y);
            }
        }
        
    }
}
