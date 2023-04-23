using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureMenuController : MonoBehaviour
{
    public GameObject furnitureMenu;
    public GameObject objectToBeSpawned;
    
    public void OnClick()
    {
        GameObject duplicate = Instantiate(objectToBeSpawned);
        duplicate.transform.position = new Vector3(Camera.main.transform.position.x, 0, Camera.main.transform.position.z + 2);
    }

    public void OnBackButtonClick(GameObject objectsMenu)
    {
        furnitureMenu.SetActive(false);
        objectsMenu.SetActive(true);
    }
}
