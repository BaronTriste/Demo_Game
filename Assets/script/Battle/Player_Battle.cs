using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Battle : MonoBehaviour
{
    public int menu1;
    public int menu2;
    public int select;
    public int selectmax;
    public bool incomp;
    public bool myturn;
    public bool ininv;
    public bool inselect;
    public GameObject inv;
    public GameObject comp;
    public GameObject textcomp;
    public GameObject talk;
    public GameObject fleche1;
    public GameObject fleche2;
    public GameObject fleche3;
    public GameObject fleche4;
    public GameObject fleche5;
    // Start is called before the first frame update
    void Start()
    {
        incomp = false;
        ininv = false;
        inselect = false;
        myturn = true;
        menu1 = 0;
        menu2 = 0;
        select = 0;
        GameObject.Find("icone_Comp").GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().CompetenciesSprite[0];
        GameObject.Find("icone_Comp 2").GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().CompetenciesSprite[1];
        GameObject.Find("icone_Comp 3").GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().CompetenciesSprite[2];
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 1)
        {
            GameObject.Find("life (1)").SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 2)
        {
            GameObject.Find("life (2)").SetActive(false);
        }
        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[28];
        GameObject.Find("slot1").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[0];
        GameObject.Find("slot2").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[1];
        GameObject.Find("slot3").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[2];
        GameObject.Find("slot4").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[3];
        GameObject.Find("slot5").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[4];
        GameObject.Find("slot6").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[5];
        inv = GameObject.Find("invotoryM");
        comp = GameObject.Find("competencies_bar");
        textcomp = GameObject.Find("competence Texte");
        talk = GameObject.Find("talk");
        inv.SetActive(false);
        talk.SetActive(true);
        comp.SetActive(false);
        textcomp.SetActive(false);
        fleche1 = GameObject.Find("flèche1");
        fleche1.SetActive(false);
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] != "0")
        {
            fleche2 = GameObject.Find("flèche2");
            fleche2.SetActive(false);
            selectmax++;
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] != "0")
        {
            fleche3 = GameObject.Find("flèche3");
            fleche3.SetActive(false);
            selectmax++;
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] != "0")
        {
            fleche4 = GameObject.Find("flèche4");
            fleche4.SetActive(false);
            selectmax++;
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] != "0")
        {
            fleche5 = GameObject.Find("flèche5");
            fleche5.SetActive(false);
            selectmax++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (myturn)
        {
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 1)
            {
                GameObject.Find("life (1)").SetActive(false);
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 2)
            {
                GameObject.Find("life (2)").SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (ininv)
                {
                    ininv = false;
                    inv.SetActive(false);
                    GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
                    menu2 = 0;
                    menu1 = 0;
                    myturn = false;
                }
                else if(incomp && inselect == false)
                {
                    inselect = true;
                    fleche1.SetActive(true);
                }
                else if (inselect)
                {
                    if (menu1 == 0)
                    {
                        incomp = false;
                        comp.SetActive(false);
                    }
                    GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
                    talk.SetActive(false);
                    menu2 = 0;
                    menu1 = 0;
                    inselect = false;
                    myturn = false;
                }
                else if (menu1 == 0 || menu1 == 1)  
                {
                    GameObject.Find("talk").transform.position = new Vector3(3.7f, 3.796653f, 0f);
                    if (menu1 == 0)
                    {
                        textcomp.SetActive(true);
                        incomp = true;
                        comp.SetActive(true);
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competenciesText[menu2];
                        GameObject.Find("competence Texte").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies[menu2];
                    }
                    if (menu1 == 1)
                    {
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
                        ininv = true;
                        inv.SetActive(true);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (menu2 == 0 && incomp && !inselect)
                {
                    menu2 = 0;
                    incomp = false;
                    GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
                    comp.SetActive(false);
                    if (menu1 != 0)
                        menu1 -= 1;
                    if (menu1 == 0)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[28];
                    if (menu1 == 1)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[29];
                    if (menu1 == 2)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[30];
                }
                else if (menu2 != 0 && incomp && !inselect)
                {
                    menu2 -= 1;
                    GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competenciesText[menu2];
                    GameObject.Find("competence Texte").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies[menu2];
                }
                else if (ininv)
                {
                    menu2 = 0;
                    ininv = false;
                    GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
                    inv.SetActive(false);
                    if (menu1 != 0)
                        menu1 -= 1;
                    if (menu1 == 0)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[28];
                    if (menu1 == 1)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[29];
                    if (menu1 == 2)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[30];
                }
                else if (inselect)
                {
                    fleche1.SetActive(false);
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] != "0")
                    {
                        fleche2.SetActive(false);
                    }
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] != "0")
                    {
                        fleche3.SetActive(false);
                    }
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] != "0")
                    {
                        fleche4.SetActive(false);
                    }
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] != "0")
                    {
                        fleche5.SetActive(false);
                    }
                    if (select != 0)
                        select--;
                    else
                        select = selectmax;
                    if (select == 0)
                        fleche1.SetActive(true);
                    if (select == 1)
                        fleche2.SetActive(true);
                    if (select == 2)
                        fleche3.SetActive(true);
                    if (select == 3)
                        fleche4.SetActive(true);
                    if (select == 4)
                        fleche5.SetActive(true);
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (menu2 != 2 && incomp && !inselect)
                {
                    menu2 += 1;
                    GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competenciesText[menu2];
                    GameObject.Find("competence Texte").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies[menu2];
                }
                else if (inselect)
                {
                    fleche1.SetActive(false);
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] != "0")
                    {
                        fleche2.SetActive(false);
                    }
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] != "0")
                    {
                        fleche3.SetActive(false);
                    }
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] != "0")
                    {
                        fleche4.SetActive(false);
                    }
                    if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] != "0")
                    {
                        fleche5.SetActive(false);
                    }
                    if (select != selectmax)
                        select++;
                    else
                        select = 0;
                    if (select == 0)
                        fleche1.SetActive(true);
                    if (select == 1)
                        fleche2.SetActive(true);
                    if (select == 2)
                        fleche3.SetActive(true);
                    if (select == 3)
                        fleche4.SetActive(true);
                    if (select == 4)
                        fleche5.SetActive(true);
                }
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (incomp && !inselect)
                {
                }
                else if (ininv && menu2 != 0)
                {
                    menu2 -= 1;
                    GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
                }
                else if (ininv)
                {
                }
                else if (!incomp && !ininv)
                {
                    if (menu1 != 0)
                        menu1 -= 1;
                    if (menu1 == 0)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[28];
                    if (menu1 == 1)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[29];
                    if (menu1 == 2)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[30];
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (incomp && !inselect)
                {
                }
                else if (ininv && menu2 != 6)
                {
                    menu2 += 1;
                    GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
                }
                else if (ininv)
                {
                }
                else if(!incomp && !ininv)
                {
                    if (menu1 != 3)
                        menu1 += 1;
                    if (menu1 == 0)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[28];
                    if (menu1 == 1)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[29];
                    if (menu1 == 2)
                        GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[30];
                }
            }
        }
    }
}
