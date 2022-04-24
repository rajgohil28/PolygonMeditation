using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneController : MonoBehaviour
{
    public TMP_Text loadingPercentage;

    private void Start()
    {
        StartCoroutine(Delay());
        
    }
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("MainScene");
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f) * 100f;
            int IntegerProgress = (int)progress;
            loadingPercentage.text = IntegerProgress.ToString() + " %";
            yield return null;
        }
    }
}
