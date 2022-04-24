using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneAudioPlayer : MonoBehaviour
{
    public AudioSource SessionAudioSources;
    private int selectedSession;
    private AudioClip AudioToBePlayed;
    // Start is called before the first frame update
    private void Awake()
    {
        selectedSession = WelcomeSceneScript.m_SelectedSession;
        Debug.Log(selectedSession);
        if (selectedSession == 0)
        {
            var selectedAudio = Resources.Load<AudioClip>("Audios/Adrift.mp3");
            AudioToBePlayed = selectedAudio;
            SessionAudioSources.clip = AudioToBePlayed;
            Debug.Log("AUDIO 0 LOADED");
            SessionAudioSources.Play();
        }
        else if (selectedSession == 1)
        {
            var selectedAudio = Resources.Load<AudioClip>("Audios/Atomic Leap.mp3");
            AudioToBePlayed = selectedAudio;
            SessionAudioSources.clip = AudioToBePlayed;
        }
        else if (selectedSession == 2)
        {
            var selectedAudio = Resources.Load<AudioClip>("Audios/Purple Light.mp3");
            AudioToBePlayed = selectedAudio;
            SessionAudioSources.clip = AudioToBePlayed;
        }
        else if (selectedSession == 3)
        {
            var selectedAudio = Resources.Load<AudioClip>("Audios/HorizonWave.mp3");
            AudioToBePlayed = selectedAudio;
            SessionAudioSources.clip = AudioToBePlayed;
        }
        else if (selectedSession == 4)
        {
            var selectedAudio = Resources.Load<AudioClip>("Audios/Release Anger (256).mp3");
            AudioToBePlayed = selectedAudio;
            SessionAudioSources.clip = AudioToBePlayed;
        }
        else
        {
            var selectedAudio = Resources.Load<AudioClip>("Audios/Finding Calm_ SOS Anxiety Relief.mp3");
            AudioToBePlayed = selectedAudio;
            SessionAudioSources.clip = AudioToBePlayed;
        }
    }
    void Start()
    {
        SessionAudioSources.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Four))
        {
            SceneManager.LoadScene("WelcomeScene");
        }
    }
}
