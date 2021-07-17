using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sPowers : MonoBehaviour
{
    float range = 100f;
    public Camera cam;
    public Vector3 pushForce;
   // float objectSize;
    public Renderer targetRenderer;
    public Rigidbody rb;
    //Vector3 throwVelocty;
   
    /*
    //Function that returns the size of the object
    void sizeOfObject(GameObject  Object) 
    {
        targetRenderer = GetComponent<Renderer>();

        if (Object == null) 
        {
            return;
        }
        Object = target;
        objectSize = targetRenderer.bounds.size.magnitude;
        Debug.Log(objectSize);
    }
    */

   public void Powers()
    {
        RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                Debug.DrawLine(cam.transform.position, hit.transform.position);
                
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    //target.pushPower(pushForce);
                    target.pushPower(cam.transform.forward * pushForce.magnitude);
                }          
            }
    }
/*
    void dropObject() 
    {
        throwVelocty = cam.transform.forward * 10;
        rb.velocity = throwVelocty;
    }
*/

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Powers();
        }
        
    }

}
