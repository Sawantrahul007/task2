using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workplease : MonoBehaviour
{
    private Vector3 mOffset;
    public Vector3 cubex;
    public GameObject plane;
    public GameObject camerax;
    private static float zCord;
    //private float xlimit = 3.5f;
    //private float ylimit = 3.5f;
    //private float planeDist;
    //private RaycastHit shot;
    private RaycastHit rx;
    public float x;
    public float y;
    public float zy;
    public LayerMask layermask;
    public static float hm;
    public static float offset;
    public float zc;
    public Vector3 limitvect;
    Texture2D t;

    //private void Update()
    //{
    //    transform.rotation = plane.transform.rotation;
    //    //camerax.transform.LookAt(gameObject.transform);


    //    //int mask = 1 << LayerMask.NameToLayer("plane");
    //    //mask |= 1 << LayerMask.NameToLayer("cube");
    //    // Debug.DrawRay(camerax.transform.position, cubex*20);
    //    //float maxDistance = 50.0f;

    //    // Debug.DrawRay(camerax.transform.position, cubex*20);
    //}
    //private void LateUpdate()
    //{
    //    //if (transform.position.x > xlimit)
    //    // {
    //    //     transform.position = new Vector3(xlimit, transform.position.y, transform.position.z);
    //    // }
    //    // else if (transform.position.x < -xlimit)
    //    // {
    //    //     transform.position = new Vector3(-xlimit, transform.position.y, transform.position.z);
    //    // }
    //    // if (transform.position.y > ylimit)
    //    // {
    //    //     transform.position = new Vector3(transform.position.x, ylimit, transform.position.z);
    //    // }
    //    // else if (transform.position.y < -ylimit)
    //    // {
    //    //     transform.position = new Vector3(transform.position.x, -ylimit, transform.position.z);
    //    // }

    //}

    void OnMouseDown()
    {
        transform.rotation = plane.transform.rotation;
       // GetMouseAsWorldPoint();
        //if(Physics.Raycast(camerax.transform.position,cubex))
        //offset = transform.position.z;
        // zCord = hm;  // ndbdhdsjjs
        // Store offset = gameobject world pos - mouse world pos
        // mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        //zy = planeDist;

        // Debug.Log(mOffset + "xx");
    }
    //private Vector3 GetMouseAsWorldPoint()
    //{
    //    // Pixel coordinates of mouse (x,y)
    //    Vector3 mousePoint = Input.mousePosition;
    //    // z coordinate of game object on screen
    //    //zCord = hm;

    //  // mousePoint.z = rx.point.z-1;// jdjdjdjdjd
    //  //  Debug.Log(mousePoint.z + "cc");
    //    //Debug.Log(zCord+"zCord");
    //    //Debug.Log(mousePoint.z + "mz");
    //    // Convert it to world points
    //    return Camera.main.ScreenToWorldPoint(mousePoint);
    //}
    void OnMouseDrag()
    {
        // zCord = hm;

       // + mOffset;
        Debug.Log("hitting");
        //cubex = (transform.position - camerax.transform.position).normalized;
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        int mask = 1 << 9 | 1 << 10;
        if (Physics.Raycast(r, out rx, 50, mask))
        {
            Debug.Log("hittingx");
            string m = rx.collider.tag;
            Debug.Log(m + "mm");
            //Debug.DrawRay(camerax.transform.position, cubex * 20);
            transform.position = new Vector3(rx.point.x, rx.point.y, rx.point.z - 1);
            limitvect = new Vector3(rx.point.x, rx.point.y, rx.point.z - 1);
            // Debug.Log(p + "pp");
            //hm = Vector3.Distance(p, camerax.transform.position);
            //zCord = hm;
            //Debug.Log("hsjs" + hm);
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
        //else
        //{
        //    transform.position = limitvect;
        //    Debug.Log(limitvect);
        //}

        //tracker.transform.position = Vector3.MoveTowards(tracker.transform.position, transform.position, 100);
    }
    /* void ReassignF(float zf)
     {
         hm = zf;
     }*/
}
