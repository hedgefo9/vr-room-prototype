using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragAndDropController : MonoBehaviour
{
    public GameObject[] DragablesItems;
    public GameObject Camera;

    public void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    public void OnDrag() 
    {
        DragablesItems = GameObject.FindGameObjectsWithTag("Dragable");

        foreach (GameObject obj in DragablesItems)
        {
            obj.GetComponent<Dragable>().Drag = !obj.GetComponent<Dragable>().Drag;
        }
    }

    public void OnLook(InputValue input)
    {
        Vector2 inputVector = input.Get<Vector2>();

        foreach (GameObject obj in DragablesItems)
        {
            Debug.Log((float)Math.Cos(Camera.transform.localEulerAngles.y));
            if (obj.GetComponent<Dragable>().Drag) {
                Vector3 angles = obj.transform.eulerAngles;
                obj.transform.RotateAround(Camera.transform.position, new Vector3(0, 1, 0), inputVector.x * (float)0.3);
                obj.transform.RotateAround(Camera.transform.position, Vector3.left, inputVector.y * (float)0.3);
                obj.transform.eulerAngles = angles;
            }
        }
    }

}
