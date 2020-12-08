using System.Collections;
using UnityEngine.UI;
using SilCilSystem.Variables;
using UnityEngine;

public class PealImage : MonoBehaviour
{
    [SerializeField] private VariableFloat m_rotation;
    [SerializeField] private VariableFloat m_scale;
    [SerializeField] private VariableVector3 m_vector3;

    private RectTransform m_rectTransform;

    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
        m_rotation.Value = 0.0f;
        m_scale.Value = 1.0f;
        m_vector3.Value = new Vector3(0, -1940, 0);
    }

    void Update()
    {
        m_rectTransform.localRotation = Quaternion.Euler(0,0,m_rotation);
        m_rectTransform.localScale = new Vector3(m_scale,m_scale,1);
        m_rectTransform.localPosition = m_vector3;
    }
}
