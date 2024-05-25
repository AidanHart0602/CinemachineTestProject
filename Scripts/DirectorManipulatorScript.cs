using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DirectorManipulatorScript : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _director;
    // Start is called before the first frame update
    void Start()
    {
        _director = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DirectorPlay();
        }
    }

    public void DirectorPause()
    {
        _director.Pause();
    }

    public void DirectorPlay()
    {
        _director.Play();
    }

    public void DirectorChangeScene()
    {

    }
}
