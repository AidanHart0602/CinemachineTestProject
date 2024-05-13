using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwappingScript : MonoBehaviour
{
    private Animator _animator;
    private int _animatorIDAiming;
    private int _animatorIDDeath;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animatorIDAiming = Animator.StringToHash("Aiming");
        _animatorIDDeath = Animator.StringToHash("Death");
    }

    // Update is called once per frame
    void Update()
    {
        AimCheck();
        DeathCheck();
    }

    private void AimCheck()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _animator.SetBool(_animatorIDAiming, true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            _animator.SetBool(_animatorIDAiming, false);
        }
    }
    private void DeathCheck() 
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            _animator.SetBool(_animatorIDDeath, true);
        }
    }
}
