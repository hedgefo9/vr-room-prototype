using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Plane_creating_floor : MonoBehaviour
{
     public float[,] matrix_of_floor= new float[100,100];
    [SerializeField] public bool br=false,bl=false,bt=false,bb=false;
    //massive filled by 0
    public GameObject floor;
    // Start is called before the first frame update
   private float x_center=0.0f,y_center=0.0f,z_center=0.0f;
   void Awake() {
        x_center=GetComponent<Transform>().position.x; 
        y_center=GetComponent<Transform>().position.y; 
        z_center=GetComponent<Transform>().position.z; 
   }
    void Start()
    {
       /* for(int y=0;y<100;y++){
            for(int x=0;x<100;x++){
                
                if(x<50||y%2==0){
                matrix_of_floor[y,x]=1;
                
                Instantiate(floor,new Vector3(x+x_center-50,y_center,y+z_center-50),Quaternion.Euler(0,0,0)); 
                Debug.Log(matrix_of_floor[y,x]);
                }
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Get_number_of_floor(int num1,int num2){
        br=false;
        bl=false;
        bb=false;
        bt=false;
          if(num1<99&&matrix_of_floor[num2,num1+1]==1){
            br=true;
          }
          if(num1>0&&matrix_of_floor[num2,num1-1]==1){
            bl=true;
          }

          if(num2>0&&matrix_of_floor[num2-1,num1]==1){
            bb=true;
          }

          if(num2<99&&matrix_of_floor[num2+1,num1]==1){
            bt=true;
          }
       


    }
    public void Flor_creator(float x,float y,float z){
  if(MathF.Abs(x+50)<100&&MathF.Abs(z+50)<100){
    if(matrix_of_floor[(int)z+50,(int)x+50]==0){
      Instantiate(floor,new Vector3(x+x_center,y_center,z+z_center),Quaternion.Euler(0,0,0));
      matrix_of_floor[(int)z+50,(int)x+50]=1;
    }
  }
}
}


