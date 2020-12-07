using System.Collections;
using UnityEngine.UI;
using SilCilSystem.Variables;
using UnityEngine;

public class MouthImage : MonoBehaviour
{
    [SerializeField] private VariableFloat m_positionY;
    [SerializeField] private VariableFloat m_rotationZ;
    
    private RectTransform m_rectTransform;

    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        m_rectTransform.localRotation = Quaternion.Euler(0,0,m_rotationZ);
        m_rectTransform.localPosition = new Vector3(1, m_positionY, 1);
    }
}
