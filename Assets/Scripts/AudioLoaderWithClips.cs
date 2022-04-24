using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioLoaderWithClips : MonoBehaviour
{
    public AudioClip[] audios;
    public AudioSource _audioSource;
    private int SessionNumber;
    private void Awake()
    {
        SessionNumber = WelcomeSceneScript.m_SelectedSession;
        _audioSource.clip = audios[SessionNumber];
    }
    // Start is called before the first frame update
    void Start()
    {
        _audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Start))
        {
            SceneManager.LoadSceneAsync("WelcomeScene");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadSceneAsync("WelcomeScene");
        }
    }
}
