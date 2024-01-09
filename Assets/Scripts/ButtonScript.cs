using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public void ButtonStart()
    {
       SceneManager.LoadScene("Game"); 
    }

    public void ButtonExit() 
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
