using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtMouse : MonoBehaviour
{
    // Variables
    public Plane playerPlane;
     public Transform Player;
     public Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerPlane = new Plane(Vector3.up, transform.position);
         ray = Camera.main.ScreenPointToRay (Input.mousePosition);
         float hitdist;
         
         if (playerPlane.Raycast(ray, out hitdist)) {
             Vector3 targetPoint = ray.GetPoint(hitdist);
             Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
             
             transform.rotation = targetRotation;
         }
        
    }
}
