using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GotchaResultManager : MonoBehaviour
{
    [SerializeField] private GameObject Result1;
    [SerializeField] private GameObject Result2;
    [SerializeField] private GameObject Result3;
    [SerializeField] private GameObject Result4;
    private string m_resultText;
    void Start()
    {
        Result1.SetActive(false);
        Result2.SetActive(false);
        Result3.SetActive(false);
        Result4.SetActive(false);
        float randomNum = Random.Range(0.0f, 1.0f);
        if (0.0f <= randomNum && randomNum < 0.01f)
        {
            Result1.SetActive(true);
            m_resultText = "真珠5000兆個ゲット!!!";
        } else if (0.01f <= randomNum && randomNum < 0.2f)
        {
            Result2.SetActive(true);
            m_resultText = "真珠1000個ゲット!!";
        } else if (0.2f <= randomNum && randomNum < 0.5f)
        {
            Result3.SetActive(true);
            m_resultText = "真珠100個ゲット!";
        } else if (0.5f <= randomNum && randomNum < 1.0f)
        {
            Result4.SetActive(true);
            m_resultText = "真珠10個ゲット";
        }
    }
}
