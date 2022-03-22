using System;
using System.Collections;
using Finish;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart:MonoBehaviour
{
    private static Scene _scene;
        
    void Start() => _scene = SceneManager.GetActiveScene();

    private void OnEnable() => FinishUI.NextLevel += LoadNextLevel;

    private void LoadNextLevel() => SceneManager.LoadScene(_scene.name);
        
    private void OnDisable() => FinishUI.NextLevel -= LoadNextLevel;
    
}