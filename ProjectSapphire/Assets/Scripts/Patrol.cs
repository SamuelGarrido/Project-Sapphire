using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public Transform[] waypoints;
    public int speed;
    public bool MoveRight;

    private int waypointIndex;
    private float dist;

    void Start(){
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    void Update() {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (dist < 1f) {
            IncreaseIndex();
        }
        Patroller();
    }

    void Patroller() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.LookAt(waypoints[waypointIndex].position);
    }

    void IncreaseIndex() {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length) {
            waypointIndex = 0;
        }
    }

}
