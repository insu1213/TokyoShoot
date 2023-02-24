using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
