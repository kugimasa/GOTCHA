using UnityEngine;
using UnityEngine.UI;
using SilCilSystem.Variables;
using System;

public class GotchaPigMove : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private VariableFloat m_rotation;
    [SerializeField] private VariableFloat m_position;

    private RectTransform m_rectTransform;

    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
        m_position.Value = 333;
        m_rotation.Value = 0;
    }

    void Update()
    {
        m_rectTransform.localPosition = new Vector3(0,m_position,0);
        m_rectTransform.localRotation = Quaternion.Euler(0,0,m_rotation);
    }
}
