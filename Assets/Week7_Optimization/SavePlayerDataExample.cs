using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SavePlayerDataExample : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI welcomeBackText;
    [SerializeField] private TextMeshProUGUI visitCountText;
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Button saveButton;


    private void Start()
    {
        string name = PlayerPrefs.GetString("name", "");
        int visitCount = PlayerPrefs.GetInt("visitCount", 0);
        
        if(visitCount == 0)
        {
            //don't display any text for the first time
            welcomeBackText.text = "";
            visitCountText.text = "";
        }
        else
        {
            welcomeBackText.text = "Welcome back, " + name;
            visitCountText.text = "you have visited before " + visitCount + " times";
        }

        
        PlayerPrefs.SetInt("visitCount", visitCount+1);

    }

    public void SaveData()
    {
        PlayerPrefs.SetString("name", nameInput.text);
    }
}
