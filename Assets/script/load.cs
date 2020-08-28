using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class load : MonoBehaviour
{
    void Start()
    {
        //GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().toload;
        StartCoroutine(LoadAsynchronously());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadAsynchronously()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().toload);

        GameObject.Find("selector_1").transform.position -= new Vector3(0.0f, 0.1f, 0.0f);
        // Tant que le chargement n'est pas terminÃ© on lit cette boucle
        while (!operation.isDone)
        {
            yield return null;
        }
    }
}



/*Script issu d'un tutoriel rÃ©alisÃ© par TUTO UNITY FR
// https://www.youtube.com/c/tutounityfr

// Ce script vous permet de crÃ©er des Ã©crans de chargement lors du passage d'une scÃ¨ne Ã  une autre
// Script basÃ© sur le tutoriel de Alan Zucconi : http://www.alanzucconi.com/2016/03/30/loading-bar-in-unity/

using System.Collections;
using UnityEngine;
// Librairie permettant de gÃ©rer les scÃ¨nes via script
using UnityEngine.SceneManagement;
// Librairie permettant de gÃ©rer les Ã©lÃ©ments UI
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    // RÃ©fÃ©rences aux objets
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    // Fonction de chargement de niveau appelÃ© via un bouton
    public void LoadLevel(int sceneIndex)
    {
		// DÃ©marrage de la coroutine
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    // Coroutine permettant de charger la scÃ¨ne et de mettre Ã  jour le UI en fonction de la progression
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        // Chargement de la scÃ¨ne en background
        // On stock cette ligne dans operation pour accÃ©der au pourcentage de chargement
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        // Activation de l'Ã©cran de chargement
        loadingScreen.SetActive(true);

        // Tant que le chargement n'est pas terminÃ© on lit cette boucle
        while (!operation.isDone)
        {
            // On recupÃ¨re la progression, Clamp01 bloque la valeur entre 0 et 1
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            // Attribution de la nouvelle valeur au slider
            slider.value = progress;

			// Mise Ã  jour du pourcentage de chargement
            progressText.text = progress * 100 + "%";

            // On attend un frame puis on recommance la boucle
            yield return null;
        }
    }*/