using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCube : MonoBehaviour
{
    private Vector3 mOffset;
    public Vector3 cubex;
    public GameObject plane;
    public GameObject camerax;
    private static float zCord;
    //private float xlimit = 3.5f;
   // private float ylimit = 3.5f;
    private float planeDist;
    private RaycastHit shot;
    private RaycastHit rx;
    public float x;
    public float y;
    public float zy;
    public LayerMask layermask;
    public static float hm;
    public static float offset;
    public float zc;
    private void Update()
    {
        //camerax.transform.LookAt(gameObject.transform);
        cubex = (transform.position - camerax.transform.position).normalized;
        transform.rotation = plane.transform.rotation;
        //int mask = 1 << LayerMask.NameToLayer("plane");
        //mask |= 1 << LayerMask.NameToLayer("cube");
       // Debug.DrawRay(camerax.transform.position, cubex*20);
        float maxDistance = 50.0f;
        if (Physics.Raycast(camerax.transform.position, cubex,out rx,maxDistance, ~layermask))
        {
            string m = rx.collider.tag;
            transform.position = rx.point;
            //Debug.Log(m + "mm");
            Debug.DrawRay(camerax.transform.position, cubex * 20);
            //Vector3 p = rx.point;
           // Debug.Log(p + "pp");
           // hm=Vector3.Distance(p,camerax.transform.position);
           // zCord = hm;
            Debug.Log("hsjs" + hm);
           // zc = zCord;
            /*if (rx.collider.tag == null)
            {
                // ReassignF(zCord);
                zCord = zc;
            }*/
            /*if (rx.collider.gameObject.layer == LayerMask.NameToLayer("plane"))
            {
                string m = rx.collider.tag;
                Debug.Log(m + "mm");
                Debug.DrawRay(camerax.transform.position, cubex * 20);
            }*/
            
            /*if (rx.collider.gameObject.layer == LayerMask.NameToLayer("cube"))
            {

                string m = rx.collider.tag;
                Debug.Log(m + "mm");
                
            }*/

        }
       // Debug.DrawRay(camerax.transform.position, cubex*20);
    }
    private void LateUpdate()
    {
       /* if (transform.position.x > xlimit)
        {
            transform.position = new Vector3(xlimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xlimit)
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
        }*/

    }

    void OnMouseDown()
    {
        //if(Physics.Raycast(camerax.transform.position,cubex))
        //offset = transform.position.z;

       // zCord = hm;  // ndbdhdsjjs
        // Store offset = gameobject world pos - mouse world pos
        //mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        //zy = planeDist;

        // Debug.Log(mOffset + "xx");
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        //zCord = hm;
        
       // mousePoint.z = zCord;// jdjdjdjdjd
       // Debug.Log(mousePoint.z + "cc");
        //Debug.Log(zCord+"zCord");
        //Debug.Log(mousePoint.z + "mz");
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        // zCord = hm;
        GetMouseAsWorldPoint();// + mOffset;
        //tracker.transform.position = Vector3.MoveTowards(tracker.transform.position, transform.position, 100);
    }
   /* void ReassignF(float zf)
    {
        hm = zf;
    }*/
}
