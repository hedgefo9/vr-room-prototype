using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragAndDropController : MonoBehaviour
{
    public GameObject[] DragablesItems;
    public GameObject Camera;
    public GameObject DragPoint;
    public float lerpSpeed;

    public void OnDrag() 
    {
        DragablesItems = GameObject.FindGameObjectsWithTag("Dragable");

        foreach (GameObject obj in DragablesItems)
        {
            obj.GetComponent<Dragable>().Drag = !obj.GetComponent<Dragable>().Drag;
            DragPoint.transform.position = obj.transform.position;
        }
    }

    public void OnLook(InputValue input)
    {
        Vector2 inputVector = input.Get<Vector2>();

        foreach (GameObject obj in DragablesItems)
        {
            if (obj.GetComponent<Dragable>().Drag) {

                obj.transform.position = Vector3.Lerp(obj.transform.position, DragPoint.transform.position, Time.deltaTime * lerpSpeed);
            }
        }
    }

}
