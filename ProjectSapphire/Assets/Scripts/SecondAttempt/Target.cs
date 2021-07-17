using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float weight = 50f;
    public GameObject target;
    public Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void pushPower(Vector3 amount) 
    {
        if (weight <= 50)
        {
            Push(amount);
        }
        Debug.Log(weight);
    }

    void Push(Vector3 amount) 
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * weight);
        //this.GetComponent<Rigidbody>().AddForce(Vector3.MoveTowards(target.transform.position, gameObject.transform.position, weight));
        rb.AddForce(transform.forward * weight);
    }

}
