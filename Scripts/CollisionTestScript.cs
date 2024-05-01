using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CollisionTestScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cameras;

    public void ActivateMainCamera(int camNum)
    {
        _cameras[camNum].GetComponent<CinemachineVirtualCamera>().Priority = 11;
        Debug.Log("MainCameraSet");
    }

    public  void ResetPriority() 
    {
        foreach (var i in _cameras)
        {
            i.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }
    }
}
