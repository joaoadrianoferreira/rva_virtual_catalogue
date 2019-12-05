using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class start : MonoBehaviour
{
    public string sceneName;
    public Button loadBtnScene; 

    // Start is called before the first frame update
    void Start()
    {
        loadBtnScene.onClick.AddListener(changeScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeScene()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
