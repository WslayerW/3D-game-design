using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third : MonoBehaviour
{

    public Rigidbody r1;
    // Start is called before the first frame update
    void Start()
    {
        r1.velocity = new Vector3(10, 5);//为刚体施加初速度
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
