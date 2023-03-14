using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Floor : MonoBehaviour 
{ 
    public GameObject wals; 
     
    private int[] sides ={1,-1,1,-1}; 
    public float size_of_floor=0.5f,x_center=0.0f,y_center=0.0f,z_center=0.0f; 
    private  int flag=0; 
    public GameObject[] walls = new GameObject[4]; 
 
 
    void Start() 
    { 
       Debug.Log("Start"); 
       x_center=GetComponent<Transform>().position.x; 
        y_center=GetComponent<Transform>().position.y; 
        z_center=GetComponent<Transform>().position.z; 
 
        
        
    } 
 
    // Update is called once per frame 
    void Update() 
    { 
       if(Input.GetKeyUp(KeyCode.Mouse1)&&flag==0){ 
     Debug.Log(flag); 
        for(int t=0;t<2;++t){ 
           walls[t]=Instantiate(wals,new Vector3(x_center+sides[t]*size_of_floor,y_center+size_of_floor,z_center),Quaternion.Euler(0,0,0)); 
           
        } 
        for(int t=0;t<2;++t){ 
           walls[2+t]= Instantiate(wals,new Vector3(x_center,y_center+size_of_floor,z_center+sides[t]*size_of_floor),Quaternion.Euler(0,90,0)); 
          
        } 
            flag++; 
            walls[0].name="right_wall"; 
            walls[1].name="left_wall"; 
            walls[2].name="front_wall"; 
            walls[3].name="back_wall"; 
 
 
        } 
       }  
    }
