using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiring : MonoBehaviour
{
    public GameObject firing;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Enemyfiring", 1, 2f);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Enemyfiring()
    {
        Instantiate(firing,transform.position,transform.rotation);
    }

}
