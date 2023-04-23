using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragAndDropController : MonoBehaviour
{
    public GameObject Camera;
    public GameObject DragPoint;
    private GameObject dragObject;
    public float lerpSpeed;
    Ray controllerRay;
    RaycastHit controllerRayHit;

    public void Awake()
    {
        dragObject = new GameObject();
    }

    public void OnDrag() 
    {
        if (Physics.Raycast(controllerRay, out controllerRayHit))
        {
            dragObject = controllerRayHit.collider.gameObject;
            if (dragObject.GetComponent<Dragable>() != null)
            {
                dragObject.GetComponent<Dragable>().Drag = !dragObject.GetComponent<Dragable>().Drag;
                DragPoint.transform.position = dragObject.transform.position;
            }
        }

    }

    public void OnLook(InputValue input)
    {

        controllerRay.origin = Camera.transform.position;
        controllerRay.direction = Camera.transform.forward;

        Debug.DrawRay(Camera.transform.position, Camera.transform.forward*100, Color.red);

        if (dragObject.GetComponent<Dragable>() != null)
        {
            if (dragObject.GetComponent<Dragable>().Drag)
            {
                dragObject.transform.position = Vector3.Lerp(dragObject.transform.position, DragPoint.transform.position, Time.deltaTime * lerpSpeed);
            }
        }
    }

}
