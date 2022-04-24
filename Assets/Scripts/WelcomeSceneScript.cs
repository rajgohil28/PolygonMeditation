using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeSceneScript : MonoBehaviour
{
    public static int m_SelectedSession;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectSessionNumber(int _num)
    {
        m_SelectedSession = _num;
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadSceneAsync("LoadingScene");
    }
}
