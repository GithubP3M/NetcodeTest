using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForceJump : MonoBehaviour
{
    public Rigidbody subject;
    public float Force;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            subject.AddForce(0,Force,0,ForceMode.Acceleration);
        }
    }
}
