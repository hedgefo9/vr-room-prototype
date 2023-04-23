using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float sensetivity = 0.3f;
    public GameObject Camera;
    public GameObject menus;
    public GameObject FloorController;
    public GameObject DragAndDropController;
    public LineRenderer lineRenderer;
    public void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Camera.transform.localEulerAngles = Vector3.zero;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnLook(InputValue input)
    {
        lineRenderer.SetPosition(0, Camera.transform.position);
        lineRenderer.SetPosition(1, Camera.transform.position + Camera.transform.forward * 5);

        Vector2 inputVector = input.Get<Vector2>();

        if ((Camera.transform.localEulerAngles.x - inputVector.y * sensetivity <= 90)||(Camera.transform.localEulerAngles.x - inputVector.y * sensetivity >=270)) 
        {
            Camera.transform.localEulerAngles += new Vector3(-inputVector.y * sensetivity, inputVector.x * sensetivity, 0);
        }
        
    }

    public void OnChangeMode()
    {
        FloorController.SetActive(!FloorController.activeSelf);
        DragAndDropController.SetActive(!DragAndDropController.activeSelf);
    }

    public void OnMoveLeft(InputValue input)
    {
        float inputFloat = input.Get<float>();
        Camera.GetComponent<Move>().Y = inputFloat;
    }

    public void OnMoveForward(InputValue input)
    {
        float inputFloat = input.Get<float>();
        Camera.GetComponent<Move>().X = inputFloat;
    }

    void OnMenu()
    {
        if (DragAndDropController.activeSelf)
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else { Cursor.lockState = CursorLockMode.Locked; }

            menus.gameObject.SetActive(!menus.gameObject.activeSelf);
        }
    }

}
