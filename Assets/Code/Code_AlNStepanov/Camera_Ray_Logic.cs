using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Camera_Ray_Logic : MonoBehaviour
{
     [SerializeField]Camera camera_w;
     RaycastHit hit;
     private float x,y,z;
     public GameObject plate;
     private bool unblocking_button=true;
   
    

    void Update(){
        
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin,   ray.direction * 50,Color.blue,0f,true);
         if(Input.GetKeyUp(KeyCode.G)){
            unblocking_button=false;
         }
        if (unblocking_button && Input.GetKeyUp(KeyCode.Mouse0)&&Physics.Raycast(ray, out hit,50)) {
            
            
            Debug.Log(hit.point);
            
           x=MathF.Round(hit.point.x);
           y=MathF.Round(hit.point.y);
           z=MathF.Round(hit.point.z);
           Debug.Log( new Vector3(x,y,z) );
           if("Walls(Clone)"==hit.collider.gameObject.name){
            Destroy(hit.collider.gameObject);
           }
           else{
          plate.GetComponent<Plane_creating_floor>().Flor_creator(x,y,z,hit.collider);
           }
        
       
          
            

            
            // Do something with the object that was hit by the raycast.
        }
        
    }
    
}
