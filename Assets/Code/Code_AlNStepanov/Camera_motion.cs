using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_motion : MonoBehaviour
{
    private float X,Y,v,h;
    public int speeds=12,horizontalspeed=0,verticalspeed=0;
    private float eulerX=0,eulerY=0;
     void Awake() {
      Cursor.lockState =CursorLockMode.Locked;
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         X = Input.GetAxis("Mouse X") * speeds * Time.deltaTime;
    Y = -Input.GetAxis("Mouse Y") * speeds * Time.deltaTime;
         eulerX = (transform.rotation.eulerAngles.x + Y) % 360;
    eulerY = (transform.rotation.eulerAngles.y + X) % 360;
        transform.rotation = Quaternion.Euler(eulerX, eulerY, 0);
       v=Input.GetAxis("Vertical");
       h=Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0,0,1)*Time.deltaTime*v*verticalspeed);
        transform.Translate(new Vector3(1,0,0)*Time.deltaTime*h*horizontalspeed);
    if (Input.GetKeyUp (KeyCode.Escape)) {
      Cursor.lockState = CursorLockMode.None;
    }
        
    }
}

