using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Floor : MonoBehaviour 
{
[SerializeField] public bool br=false,bl=false,bt=false,bb=false;
    public GameObject wals; 
     public GameObject plate; 
    private int[] sides ={1,-1}; 
    public float size_of_floor=0.23f,x_center=0.0f,y_center=0.0f,z_center=0.0f; 
    private  int flag=0; 
    public GameObject[] walls = new GameObject[4]; 
    public int num1=0,num2=0;
    private Transform tf;
    private Renderer flor_render;
     void Awake() {
      tf=GetComponent<Transform>();
      flor_render=GetComponent<Renderer>();
        x_center=tf.position.x; 
        y_center=tf.position.y; 
        z_center=tf.position.z; 
        size_of_floor=tf.lossyScale.x  /2;
        num1=(int)x_center+50;
        num2=(int)z_center+50;
        
    }
 
 
    void Start() 
    { 
    } 

 
    // Update is called once per frame 
    void LateUpdate() 
    { if(Input.GetKeyUp(KeyCode.G)){
      flag=10;
    }
       if(Input.GetKeyUp(KeyCode.Mouse1)&&flag==0){ 
     Debug.Log(flag); 
     plate.GetComponent<Plane_creating_floor>().Get_number_of_floor(num1,num2);
     br=plate.GetComponent<Plane_creating_floor>().br;
     bl=plate.GetComponent<Plane_creating_floor>().bl;
     bt=plate.GetComponent<Plane_creating_floor>().bt;
     bb=plate.GetComponent<Plane_creating_floor>().bb;
        for(int t=0;t<2;++t){ 
         if((t==0&&plate.GetComponent<Plane_creating_floor>().br)||(t==1&&plate.GetComponent<Plane_creating_floor>().bl)){
            continue;
            
         }

         
           walls[t]=Instantiate(wals,new Vector3(x_center+sides[t]*size_of_floor,y_center+size_of_floor,z_center),Quaternion.Euler(0,0,0)); 
         

        } 
        for(int t=0;t<2;++t){ 
         if((t==0&&plate.GetComponent<Plane_creating_floor>().bt)||(t==1&&plate.GetComponent<Plane_creating_floor>().bb)){
            continue;
         }
           walls[2+t]= Instantiate(wals,new Vector3(x_center,y_center+size_of_floor,z_center+sides[t]*size_of_floor),Quaternion.Euler(0,90,0)); 
          
        } if(gameObject.name=="Flor(Clone)"){
         flor_render.material.color = new Color (1f, 0f, 1f, 1f);}
            flag++; 
 
        } 
       }  
    }
