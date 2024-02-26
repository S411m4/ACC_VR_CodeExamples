using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneToNextScene : MonoBehaviour
{
    public AsyncOperation loadingOperation;
    void Start()
    {
        loadingOperation = SceneManager.LoadSceneAsync(LoadingData.sceneToLoad);
    }

   
}
