using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cameras;
    public int _currentCamera;
    public bool _cameraTriggerEnabled = false;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(_cameraTriggerEnabled == true) 
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (_currentCamera <= 2)
                {
                    _currentCamera++;
                }

                if (_currentCamera >= 3)
                {
                    _currentCamera = 0;
                }
                ResetPriority();
                SetCamera();
            }
        }
    }

    public void ResetPriority()
    {
        foreach(var i in _cameras) 
        {
            if (i.GetComponent<CinemachineVirtualCamera>())
            {
                i.GetComponent<CinemachineVirtualCamera>().Priority = 10;
            }
            if (i.GetComponent<CinemachineBlendListCamera>())
            {
                i.GetComponent<CinemachineBlendListCamera>().Priority = 10;
            }  
        }
    }
    
    public void SetCamera()
    {
       
        if (_cameras[_currentCamera].GetComponent<CinemachineVirtualCamera>())
        {
            _cameras[_currentCamera].GetComponent<CinemachineVirtualCamera>().Priority = 15;
        }
        if (_cameras[_currentCamera].GetComponent<CinemachineBlendListCamera>())
        {
            _cameras[_currentCamera].GetComponent<CinemachineBlendListCamera>().Priority = 15;
        }
    }

}
