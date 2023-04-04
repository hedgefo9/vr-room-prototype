using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float sensetivity = 0.3f;
    public void Start()
    {
        transform.localEulerAngles = Vector3.zero;
    }
    public void OnLook(InputValue input)
    {
        Vector2 inputVector = input.Get<Vector2>();

        if ((transform.localEulerAngles.x - inputVector.y * sensetivity <= 90)||(transform.localEulerAngles.x - inputVector.y * sensetivity >=270)) 
        {
            transform.localEulerAngles += new Vector3(-inputVector.y * sensetivity, inputVector.x * sensetivity, 0);
        }
        
    }
}
