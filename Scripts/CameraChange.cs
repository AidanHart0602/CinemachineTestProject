using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField]
    private GameObject[] virtualCameras;
    [SerializeField]
    private int virtualCamNum = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwapCamera();
        }  
    }

    private void SwapCamera()
    {
        if (virtualCamNum == 3)
        {
            virtualCameras[virtualCamNum].SetActive(false);
            virtualCamNum = 0;
            virtualCameras[virtualCamNum].SetActive(true);
            return;
        }

        if (virtualCamNum <= 2)
        {
            virtualCameras[virtualCamNum].SetActive(false);
            virtualCamNum += 1;
            virtualCameras[virtualCamNum].SetActive(true);
        }
    }
}
