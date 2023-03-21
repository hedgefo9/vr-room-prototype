using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        for(int y=0;y<10;y++){
            for(int x=0;x<10;x++){
                
                
                matrix_of_floor[y,x]=1;
                
                Instantiate(floor,new Vector3(x+x_center-5,y_center,y+z_center-5),Quaternion.Euler(0,0,0)); 
                Debug.Log(matrix_of_floor[y,x]);
            }
        }
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
          if(num1<9&&matrix_of_floor[num2,num1+1]==1){
            br=true;
          }
          if(num1>0&&matrix_of_floor[num2,num1-1]==1){
            bl=true;
          }

          if(num2>0&&matrix_of_floor[num2-1,num1]==1){
            bb=true;
          }

          if(num2<9&&matrix_of_floor[num2+1,num1]==1){
            bt=true;
          }
       


    }
}
