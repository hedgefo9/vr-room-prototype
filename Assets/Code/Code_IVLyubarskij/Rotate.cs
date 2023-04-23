using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 0;
    public float rotationSpeed;

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, speed * rotationSpeed));
    }
}
