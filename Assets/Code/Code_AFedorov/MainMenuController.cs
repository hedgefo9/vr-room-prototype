using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject objectsMenu;
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
                Debug.Log("Кнопка 'Сброс' нажата");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case 2:
                Debug.Log("Кнопка 'Настройки' нажата");
                break;
            case 3:
                Debug.Log("Кнопка 'Меню объектов' нажата");
                transform.parent.gameObject.SetActive(false);
                objectsMenu.SetActive(true);
                break;
            case 4:
                Debug.Log("Кнопка 'Выход' нажата");
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #endif
                Application.Quit();
                break;
        }
    }
}
