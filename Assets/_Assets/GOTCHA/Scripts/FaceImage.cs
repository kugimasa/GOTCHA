using System.Collections;
using UnityEngine.UI;
using SilCilSystem.Variables;
using UnityEngine;

public class FaceImage : MonoBehaviour
{
    [SerializeField] private VariableFloat m_rotationZ;

    private RectTransform m_rectTransform;

    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
        m_rotationZ.Value = 0.0f;
    }

    void Update()
    {
        m_rectTransform.localRotation = Quaternion.Euler(0,0,m_rotationZ);
    }
}
