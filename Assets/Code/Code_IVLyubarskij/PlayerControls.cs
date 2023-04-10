using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float sensetivity = 0.3f;
    public GameObject Camera;
    public void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Camera.transform.localEulerAngles = Vector3.zero;
    }

    public void OnLook(InputValue input)
    {
        Cursor.visible = false;
        Vector2 inputVector = input.Get<Vector2>();

        if ((Camera.transform.localEulerAngles.x - inputVector.y * sensetivity <= 90)||(Camera.transform.localEulerAngles.x - inputVector.y * sensetivity >=270)) 
        {
            Camera.transform.localEulerAngles += new Vector3(-inputVector.y * sensetivity, inputVector.x * sensetivity, 0);
        }
        
    }
}
