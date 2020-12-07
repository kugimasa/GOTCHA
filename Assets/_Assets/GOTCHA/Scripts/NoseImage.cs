using System.Collections;
using UnityEngine.UI;
using SilCilSystem.Variables;
using UnityEngine;

public class NoseImage : MonoBehaviour
{
    [SerializeField] private VariableFloat m_scale;
    [SerializeField] private VariableFloat m_rotationZ;
    
    private RectTransform m_rectTransform;

    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        m_rectTransform.localRotation = Quaternion.Euler(0,0,m_rotationZ);
        m_rectTransform.localScale = new Vector3(m_scale, m_scale, 1);
    }
}
