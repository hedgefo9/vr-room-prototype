using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureMenuController : MonoBehaviour
{
    public GameObject furnitureMenu;
    public GameObject objectToBeSpawned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick()
    {
        GameObject duplicate = Instantiate(objectToBeSpawned);
        duplicate.transform.position = new Vector3(Camera.main.transform.position.x, 0, Camera.main.transform.position.z + 4);
    }

    public void OnBackButtonClick(GameObject objectsMenu)
    {
        furnitureMenu.SetActive(false);
        objectsMenu.SetActive(true);
    }
}
