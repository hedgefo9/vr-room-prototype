using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusController : MonoBehaviour
{
    public GameObject menus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnOpenCloseMenu()
    {
        menus.gameObject.SetActive(!menus.gameObject.activeSelf);
    }
}
