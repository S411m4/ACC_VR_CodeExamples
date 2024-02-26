using UnityEngine.UI;
using UnityEngine;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] private Image loadingBar;

    [SerializeField] private LoadingSceneToNextScene nextScene;

    private void Update()
    {
       loadingBar.fillAmount =  nextScene.loadingOperation.progress;
    }
}
