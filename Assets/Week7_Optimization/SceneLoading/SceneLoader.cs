using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int loadingSceneIndex;
    public static SceneLoader Instace;
   
    private void Start()
    {
        //to keep object persistent across different scenes
        
        if(Instace == null) { Instace = this; }
        else{ Destroy(this.gameObject);return; }
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadFirstScene()
    {
        //load scene by name
        SceneManager.LoadScene("1_Shaders");
        //load scene by index
        //SceneManager.LoadScene(0);
    }

    public void LoadSceneAdditive(int sceneIndex)
    {
        //adds the next scene to game view with the previous scene still there
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }

    public void ReloadCurrentScene()
    {
        //get the index of current active scene and re-load it
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        //get sceneIndex in range 0 - (scenesInBuild-1)
        int sceneIndex = (SceneManager.GetActiveScene().buildIndex + 1);

        if (sceneIndex == loadingSceneIndex)
        { sceneIndex++; }

        
        sceneIndex = sceneIndex %  SceneManager.sceneCountInBuildSettings;

        SceneManager.LoadScene(sceneIndex);

    }

    public void LoadNextSceneAsyncWithLoadingPage()
    {
        this.gameObject.SetActive(false);

        int sceneIndex = (SceneManager.GetActiveScene().buildIndex + 1);
        if (sceneIndex == loadingSceneIndex) {  sceneIndex++; }
        sceneIndex = sceneIndex %  SceneManager.sceneCountInBuildSettings;

        SceneManager.LoadSceneAsync(loadingSceneIndex);
        LoadingData.sceneToLoad = sceneIndex;
    }

   


}
