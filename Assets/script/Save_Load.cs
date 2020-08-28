using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Save_Load : MonoBehaviour
{
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(this.gameObject);
    }

    public void SaveGame()
    {
        // 1
        DataSave data = new DataSave();
        data.ennemieG = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().ennemieG;
        data.competencies = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies;
        data.competenciesText = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competenciesText;
        data.inventory = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory;
        data.inventoryTexte = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte;
        data.all_text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text;
        data.x = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        data.y = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        data.z = GameObject.FindGameObjectWithTag("Player").transform.position.z;

        // 2
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.txt");
        bf.Serialize(file, data);
        file.Close();

        Debug.Log("Game Saved");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Menu")
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            Destroy(this.gameObject);
        }
        if (scene.name == "Main_Game")
        {
            this.gameObject.SetActive(true);
        }
        if (scene.name == "Battle")
        {
            
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }

    public void LoadGame()
    {
        // 1
        if (File.Exists(Application.persistentDataPath + "/gamesave.txt"))
        {
            // 2
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.txt", FileMode.Open);
            DataSave data = (DataSave)bf.Deserialize(file);
            file.Close();

            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().ennemieG = data.ennemieG;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies = data.competencies;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competenciesText = data.competenciesText;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory = data.inventory;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte = data.inventoryTexte;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text = data.all_text;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().posPlayer.x = data.x;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().posPlayer.y = data.y;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().posPlayer.z = data.z;
            Debug.Log("Game load");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }
}
