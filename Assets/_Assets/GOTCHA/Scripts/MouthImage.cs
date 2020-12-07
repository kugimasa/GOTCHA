using System.Collections;
using UnityEngine.UI;
using SilCilSystem.Variables;
using UnityEngine;

public class MouthImage : MonoBehaviour
{
    [SerializeField] private VariableFloat m_positionY;
    [SerializeField] private VariableFloat m_rotationZ;
    [SerializeField] private VariableBool m_mouthMove;
    
    private RectTransform m_rectTransform;

    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        m_rectTransform.localRotation = Quaternion.Euler(0,0,m_rotationZ);
        if (m_mouthMove)
        {
            m_rectTransform.localPosition = new Vector3(6.6f, m_positionY, 0.0f);
        }
    }
}
