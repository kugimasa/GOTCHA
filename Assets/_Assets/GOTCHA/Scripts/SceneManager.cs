using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SilCilSystem.Singletons;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    private string m_currentSceneName;
    [SerializeField] private string m_nextSceneName = default;
    [SerializeField] private SoundManager m_soundManager = default;
    
    private void Start()
    {
        m_currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        if (m_currentSceneName == "Start")
        {
            if (Input.anyKeyDown)
            {
                m_soundManager.PlaySelected();
                SceneLoader.LoadScene(m_nextSceneName);
            }
        }
    }

    public void LoadScene()
    {
        SceneLoader.LoadScene(m_nextSceneName);      
    }
}
