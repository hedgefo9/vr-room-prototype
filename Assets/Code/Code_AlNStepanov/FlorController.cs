using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlorController : MonoBehaviour
{private GameObject[] floors;
private GameObject plane;
private GameObject rays;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
    private void OnBuild_wals(){
      
      floors=GameObject.FindGameObjectsWithTag("Flor");
      foreach (GameObject item in floors)
      {
        item.GetComponent<Floor>().Walls_builder();
      }
      plane = GameObject.FindGameObjectWithTag("Plane");
      plane.GetComponent<Plane_creating_floor>().Clear_matrix();
      

     }
     private void OnBlock_any_actions(){
        floors=GameObject.FindGameObjectsWithTag("Flor");
         foreach (GameObject item in floors)
      {
        item.GetComponent<Floor>().Blockirator();
      }
      rays= GameObject.FindGameObjectWithTag("MainCamera");
      rays.GetComponent<Camera_Ray_Logic>().Blockirovochka();
     }
    private void OnBeam_release(){
      rays= GameObject.FindGameObjectWithTag("MainCamera");
      rays.GetComponent<Camera_Ray_Logic>().Plane_and_Wall_changes();

    }
}
