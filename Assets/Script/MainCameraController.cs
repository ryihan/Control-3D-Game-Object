using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {}
    public void Scope (Transform  target,Vector3  railDirection){
        /*
        * object position Terget 
        */
        Vector3 heading = target.position - transform.position;
        Vector3 force = Vector3.Project(heading, railDirection);
        // GetComponent<Rigidbody>().AddForce(force);
       // Debug.Log(target.position);# Visual Studio cache directory
    }
    // Update is called once per frame
    void Update()
    {
        Transform  target;
    float target = target.position.x;
        Debug.Log(target);
    }
}
