using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.M))
      {
        LoadScene();
      }  
    }

    void LoadScene()
    {
      SceneManager.LoadScene(0);
    }
}
