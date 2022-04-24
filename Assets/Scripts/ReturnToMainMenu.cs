using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ReturnToTitleScreen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ReturnToTitleScreen()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("WelcomeScene");
    }
}
