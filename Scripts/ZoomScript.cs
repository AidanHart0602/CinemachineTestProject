using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomScript : MonoBehaviour
{
    private CinemachineVirtualCamera _cam;
    
    void Start()
    {
        _cam = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        FOVChange();
    }
    void FOVChange()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float FOV = _cam.m_Lens.FieldOfView -= 20;
            if (FOV < 20)
            {
                _cam.m_Lens.FieldOfView = 60;
            }
        }
    }
}
