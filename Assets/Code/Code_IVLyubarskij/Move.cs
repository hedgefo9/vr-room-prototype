using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float X = 0;
    public float Y = 0;
    public float speed;

    void Update()
    {
        gameObject.transform.position += gameObject.transform.right * Y * speed;
        gameObject.transform.position += gameObject.transform.forward * X * speed;
        lineRenderer.SetPosition(0, gameObject.transform.position);
        lineRenderer.SetPosition(1, gameObject.transform.position + gameObject.transform.forward * 5);
    }
}
