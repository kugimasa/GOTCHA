using UnityEngine;
using UnityEngine.UI;
using SilCilSystem.Variables;
using System;

public class cameraMove : MonoBehaviour
{
    
    [Header("Variables")]
    [SerializeField] private VariableFloat m_cameraFOV;
    [SerializeField] private VariableFloat m_positionY;

    private Transform m_transform;
    private Camera m_camera;

    void Start()
    {
        m_transform = GetComponent<Transform>();
        m_camera = GetComponent<Camera>();
    }

    void Update()
    {
        m_transform.position = new Vector3(540,m_positionY,-4250);
        m_camera.fieldOfView = m_cameraFOV;
    }
}
