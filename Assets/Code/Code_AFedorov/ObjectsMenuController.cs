using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMenuController : MonoBehaviour
{
    public GameObject furnitureMenu;
    public GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick(int buttonId)
    {
        switch (buttonId)
        {
            case 1:
                Debug.Log("Кнопка 'Мебель' нажата");
                transform.parent.gameObject.SetActive(false);
                furnitureMenu.SetActive(true);
                break;
            case 2:
                Debug.Log("Кнопка 'Пол' нажата");
                break;
            case 3:
                Debug.Log("Кнопка 'Главное меню' нажата");
                transform.parent.gameObject.SetActive(false);
                mainMenu.SetActive(true);
                break;
            case 4:
                Debug.Log("Кнопка 'Стены' нажата");
                break;
        }
    }
}