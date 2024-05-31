using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class ConversationTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject Director;
    [SerializeField]
    private CinemachineVirtualCamera PlayerCamera;
    // Start is called before the first frame update
    void Start()
    {
        Director.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Director.SetActive(true);
        }
    }

    public void SetPriority()
    {
        PlayerCamera.Priority = 11;
    }
}
