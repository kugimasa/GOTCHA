using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SilCilSystem.Singletons;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private string m_nextSceneName = default;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("hoge");
            SceneLoader.LoadScene(m_nextSceneName);
        }
    }
}
