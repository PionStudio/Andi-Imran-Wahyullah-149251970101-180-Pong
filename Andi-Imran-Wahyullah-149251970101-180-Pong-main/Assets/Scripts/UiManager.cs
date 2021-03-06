using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DebugButton(string debugMsg)
    {
        Debug.Log(debugMsg);
    }

    public void ActivateUi(GameObject uiTarget)
    {
        uiTarget.SetActive(true);
    }

    public void DeactivateUi(GameObject uiTarget)
    {
        uiTarget.SetActive(false);
    }
}
