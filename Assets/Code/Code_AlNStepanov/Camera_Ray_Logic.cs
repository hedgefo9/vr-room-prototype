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
     Ray ray;
     //Vector3 Ray_start_position = new Vector3(Screen.width/2, Screen.height/2, 0);
   
    

    void Update(){
        
         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         //ray = Camera.main.ScreenPointToRay(Ray_start_position);
        Debug.DrawRay(ray.origin,   ray.direction * 50,Color.blue,0f,true);

        
        
    }
    public void Blockirovochka(){
       unblocking_button=false;
    }
    public void Plane_and_Wall_changes(){
        if (unblocking_button &&Physics.Raycast(ray, out hit,50)) {
            
            
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
        
       
          

        }
    }
    
}
