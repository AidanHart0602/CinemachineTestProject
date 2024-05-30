using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _chestDirector;

    [SerializeField]
    private GameObject _gun;
    // Start is called before the first frame update
    void Start()
    {
        _chestDirector.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has activated trigger");

        if(other.tag == "Player")
        {
            _chestDirector.SetActive(true);
        }
    }

    public void ActivateGun()
    {
        _gun.SetActive(true);
    }

}
