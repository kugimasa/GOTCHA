using UnityEngine;
using UnityEngine.UI;
using SilCilSystem.Variables;
using System;

public class HippareText : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private VariableFloat m_textScaleY;
    [SerializeField] private VariableFloat m_textPositionY;
    
    private RectTransform m_rectTransform;

    private void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        m_rectTransform.localPosition = new Vector3(0, m_textPositionY,0);
        m_rectTransform.localScale = new Vector3(1, m_textScaleY, 1);
    }
}
