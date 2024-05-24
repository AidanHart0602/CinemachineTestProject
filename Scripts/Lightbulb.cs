using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb : MonoBehaviour
{
    [SerializeField]
    private GameObject LightbulbDirector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            LightbulbDirector.SetActive(true);
            Debug.Log("Director is now active");
        }

    }
}
