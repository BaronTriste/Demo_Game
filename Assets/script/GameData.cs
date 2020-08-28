using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public int Life;
    public GameObject obj;
    public int nbActualFigth;
    public int[] ennemieG;
    public int[] quest;
    public string[] map;
    public string toload;
    public int location;
    public string[] battleEnnemie;
    public string[] competencies;
    public string[] competenciesText;
    public Sprite[] CompetenciesSprite;
    public string[] inventory;
    public string[] inventoryTexte;
    public string[] all_text;
    public Vector3 posPlayer;

    // Start is called before the first frame update
    void Start()
    {
        ennemieG = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        quest = new int[] { 0, 0, 0, 0};
        map = new string[] { "shenty_town", "", "", "", "" };
        location = 0;
        battleEnnemie = new string[] { "", "", "", "", "" };
        competencies = new string[] { " ", " ", " " };
        competenciesText = new string[] { "", "", "" };
        inventory = new string[] { " ", " ", " ", " ", " ", " " };
        inventoryTexte = new string[] { "", "", "", "", "", "" };
        all_text = new string[]
        { // competence 0-4
       "Espèce de croco pas bo !", "Le bleu c pas bo !", "", "", "",
       // competenceTexte 5-9   
       "Inflige de gros dégat", "Inflige de faible dégat, inflige 'triste' à un ennemi", "", "", "",
       // nom ennemie 10-15
       "squelette", "zombie", "rat", "Le nécromancien", "Le roi des rats", "",
       // nom objet  16-21
       "potion de lait", "grosse potion de lait", "sirop pour la toux", "", "", "",
       // texte objet  22-27
       "Soigne un coeur", "Soigne deux coeur", "augmente les dégats", "", "", "Ce n'est pas un objet valide",
       // texte combat 28-34
       "Lance une insulte !", "Utilise un objet de ton inventaire", "Fuir le combat", "vous lancer une insulte !", " vous attaque !", "", "",
       // dialog 35-42
       "", "", "", "", "", "", "", "",
       // dialog PNG1 43-50
       "Salut !", "Salut...", ":)", "", "", "", "", "",
       // dialog PNG1 51-59
        "Apuyer sur E", "", "", "", "", "", "", "", "",
        // menu pause 60-77
        "Inventaire", "UnderBook", "Option", "Menu Principale", "Resolution", "Plein Ecran", "Son Effect", "Son musique", "Utiliser", "Changer place", "jeter", "modifier touche", "sélectionner object...", "échanger avec...", "" , "", "", "",
        // texte combat didactitielle 78-84
        "Bon... ils ont engagée le combat en entrant en contact avec nous.", "En combat tu peux attaquer, utiliser un objet de ton inventaire ou t'enfuir (mais bon la on est coincée). Tu as déjà vaincu combien de monstre champions ?",
        "Heu... Une fois j'ai déjà vaincu ma grand-mère, mais je cois qu'elle m'a laissée gagnée...", "Quoi ! Mais tu dois biens avoir des capacitées ou quoi ce soit.",
        "Bas je sais pas...", "Bon attends, tu vois ce zombie ? Frappe le !", "OK !"};
        posPlayer = new Vector3(6.89f, -2.34f, 0.0f);
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
        if (scene.name == "Menu")
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            Destroy(this.gameObject);
        }
        if (scene.name == "shenty_town")
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


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            GameObject.Find("Save_Load_Sys").GetComponent<Save_Load>().SaveGame();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject.Find("Save_Load_Sys").GetComponent<Save_Load>().LoadGame();
        }
    }
}
