using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{
    public int Life;
    public GameObject obj;
    public int[] ennemieG = { 0, 0, 0, 0, 0, 0, 0};
    public string[] battleEnnemie = { "", "", "", "", ""};
    public string[] competencies = { "", "", "" };
    public string[] competenciesText = { "", "", "" };
    public Sprite[] CompetenciesSprite;
    public string[] inventory = { "", "", "", "", "", ""};
    public string[] inventoryTexte = { "", "", "", "", "", "" };
    public string[] all_text = 
   { // competence 0-4
   "Espèce de croco pas bo !", "Le bleu c pas bo !", "", "", "",
   // competenceTexte 5-9
   "Inflige de gros dégat", "Inflige de faible dégat, inflige 'triste' à un ennemi", "", "", "",
   // nom ennemie 10-15
   "squelette", "zombie", "rat", "Le nécromancien", "Le roi des rats", "",
   // nom objet  16-21
   "potion", "", "", "", "", "",
   // texte objet  22-27
   "Soigne un coeur", "", "", "", "", "",
   // texte combat 28-34
   "Lance une insulte !", "Utilise un objet de ton inventaire", "Fuir le combat", "", "", "", "",
   // dialog 35-43
   "", "", "", "", "", "", "", "" };
    public Vector3 posPlayer;

    // Start is called before the first frame update
    void Start()
    {
        posPlayer = new Vector3(-1.43f, -2.39f, 0.0f);
        Life = 3;
        inventory[0] = all_text[16];
        inventoryTexte[0] = all_text[22];
        SceneManager.sceneLoaded += OnSceneLoaded;
        competencies[0] = all_text[0];
        competencies[1] = all_text[1];
        competenciesText[0] = all_text[5];
        competenciesText[1] = all_text[6];
        DontDestroyOnLoad(this.gameObject);
    }

    public Vector3 getposPlayer()
    {
        return posPlayer;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Title")
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            Destroy(this.gameObject);
        }
        if (scene.name == "Main_Game")
        {
            for (int i = 0; i != 7; i++)
            {
                if (ennemieG[i] == 1)
                {
                    i++;
                    obj = GameObject.Find("Groupe_Ennemie" + i.ToString());
                    obj.SetActive(false);
                }

            }
            this.gameObject.SetActive(scene.name == "Main_Game");
        }
        else
        {
            this.gameObject.SetActive(scene.name == "Battle");
        }
    }


    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().posPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
            SceneManager.LoadScene("Battle");
        }
        if (Input.GetKey(KeyCode.A))
        {
            SceneManager.LoadScene("Main_Game");
        }*/
    }
}
