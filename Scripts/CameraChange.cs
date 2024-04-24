using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField]
    private GameObject[] virtualCameras;
    private bool undoSwap = false;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwapCamera();
        }  
    }

    private void SwapCamera()
    {
        if(undoSwap == true)
        {
            virtualCameras[0].SetActive(true);
            virtualCameras[1].SetActive(true);
            undoSwap = false;
        }
        else
        {
            virtualCameras[0].SetActive(false);
            virtualCameras[1].SetActive(false);
            undoSwap = true;
        }
    }
}
