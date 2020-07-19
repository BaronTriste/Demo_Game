using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void loadNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void TaskOnClick()
    {
        loadNextScene("Main_Game");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

