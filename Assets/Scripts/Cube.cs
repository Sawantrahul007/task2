using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Vector3 mOffset;
    public GameObject plane;
    public GameObject cameara;
    private float zCord;
    private float xlimit=3.5f;
    private float ylimit=3.5f;
    private float planeDist;
    private RaycastHit shot;
    public float x;
    public float y;
    public float zy;
    private void Update()
    {
        transform.rotation = plane.transform.rotation;
        cameara.transform.LookAt(gameObject.transform);
    }
    private void LateUpdate()
    {
        if(transform.position.x > xlimit)
        {
            transform.position = new Vector3(xlimit, transform.position.y, transform.position.z);
        }else if (transform.position.x < -xlimit)
        {
            transform.position = new Vector3(-xlimit, transform.position.y, transform.position.z);
        }
        if (transform.position.y > ylimit)
        {
            transform.position = new Vector3(transform.position.x, ylimit, transform.position.z);
        }
        else if (transform.position.y < -ylimit)
        {
            transform.position = new Vector3(transform.position.x, -ylimit, transform.position.z);
        }
        
    }

    void OnMouseDown()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.up), out shot))
        {
            planeDist = shot.distance;
            x = planeDist;
            

        }
        zCord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;  // ndbdhdsjjs
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        
        zy = planeDist;

       // Debug.Log(mOffset + "xx");
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        //zCord = zCord - planeDist;
        
        zCord = zCord - zy;
        mousePoint.z = zCord;
        y = 0;
        zy = 0;// jdjdjdjdjd
        //Debug.Log(zCord+"zCord");
        //Debug.Log(mousePoint.z + "mz");
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        Debug.Log(mOffset + "ss");
        if (Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.up), out shot))
        {
            planeDist = shot.distance;
            //Debug.Log(planeDist + "bb");
            //Debug.Log(planeDist+"ggx");

        }
        
        if (planeDist < x)
        {
            y = x - planeDist;
            zy = x + y;
            // transform.position=new Vector3(transform.position.x,transform.position.y,)
        }
        else if (planeDist > x)
        {
            y = planeDist - x;

            zy = x - y;
        }
        else
        {
            zy = planeDist;
        }
       // Debug.Log(planeDist + "ff");
       // zCord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        
        /*y = x - planeDist;
        if (transform.position.y < 0)
        {
            zy = x + y;
        }else if (transform.position.y > 0)
        {
            zy = x - y;
        }
        */

       // Debug.Log(zy);
        //transform.position = new Vector3(transform.position.x, transform.position.y,zy);


        transform.position = GetMouseAsWorldPoint() + mOffset;
        //tracker.transform.position = Vector3.MoveTowards(tracker.transform.position, transform.position, 100);
    }

}
