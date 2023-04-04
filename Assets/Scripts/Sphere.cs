using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject targ;
    private Rigidbody rb;
    private RaycastHit shot;
    private float targetDist;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targ.transform);
        
        //targetDist = (targ.transform.position - transform.position).normalized;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDist = shot.distance;
            
        }
        //transform.position = Vector3.MoveTowards(transform.position, targ.transform.position,100f);
        //rb.AddForce((targ.transform.position - transform.position).normalized * 10f);
        if (targetDist < 1)
        {
           // Debug.Log("gg");
            transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, 0);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, 1.5f * Time.deltaTime);
            //Debug.Log(targ.transform.position - transform.position);
        }
        
        
        
    }
    private void LateUpdate()
    {
        
        
    }
}

