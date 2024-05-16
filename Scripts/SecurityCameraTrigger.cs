using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCameraTrigger : MonoBehaviour
{
    [SerializeField]
    private CameraManager _cameraManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _cameraManager._cameraTriggerEnabled = true;
            _cameraManager.ResetPriority();
            _cameraManager._currentCamera = 0;
            _cameraManager.SetCamera();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _cameraManager._cameraTriggerEnabled = false;
            _cameraManager.ResetPriority();
            _cameraManager._currentCamera = 3;
            _cameraManager.SetCamera();            
        }
    }
}
