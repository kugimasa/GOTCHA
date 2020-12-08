using UnityEngine;
using UnityEngine.UI;
using SilCilSystem.Variables;
using System;

public class cameraMove : MonoBehaviour
{
    
    [Header("Variables")]
    [SerializeField] private VariableFloat m_cameraFOV;
    [SerializeField] private VariableFloat m_positionY;

    [SerializeField] private float _cameraFOV = default;
    [SerializeField] private float _postionY = default;
    
    private Transform m_transform;
    private Camera m_camera;

    void Start()
    {
        m_transform = GetComponent<Transform>();
        m_camera = GetComponent<Camera>();
        m_cameraFOV.Value = _cameraFOV;
        m_positionY.Value = _postionY;

    }

    void Update()
    {
        m_transform.position = new Vector3(540,m_positionY,-4250);
        m_camera.fieldOfView = m_cameraFOV;
    }
}
