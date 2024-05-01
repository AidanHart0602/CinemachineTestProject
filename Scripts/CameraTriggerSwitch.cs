using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggerSwitch : MonoBehaviour
{
    [SerializeField]
    private CollisionTestScript _collisionTest;
    [SerializeField]
    private int _camNum;


    // Start is called before the first frame update
    void Start()
    {
        _collisionTest = GameObject.Find("CameraManager").GetComponent<CollisionTestScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _collisionTest.ResetPriority();
            _collisionTest.ActivateMainCamera(_camNum);
        }
    }
}
