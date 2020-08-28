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
    public bool attack;
    public bool diddps;
    public bool myturn;
    public bool ininv;
    public bool inselect;
    public float timer;
    public bool back;
    public GameObject life3;
    public GameObject life2;
    public GameObject life1;
    public GameObject inv;
    public GameObject comp;
    public GameObject textcomp;
    public GameObject textplayer;
    public GameObject talk;
    public GameObject fleche1;
    public GameObject fleche2;
    public GameObject fleche3;
    public GameObject fleche4;
    public GameObject fleche5;
    public GameObject text_event;
    public Vector3 newpos;

    // Start is called before the first frame update
    void Start()
    {
        menu1 = 0;
        menu2 = 0;
        select = 0;
        incomp = false;
        attack = false;
        diddps = false;
        myturn = true;
        ininv = false;
        inselect = false;
        timer = 0.0f;
        back = false;
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
        text_event = GameObject.Find("Event Text");
        life1 = GameObject.Find("life");
        life2 = GameObject.Find("life (1)");
        life3 = GameObject.Find("life (2)");
        textplayer = GameObject.Find("talkPlayer");
        textplayer.SetActive(false);
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

    void Object_usage()
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2] == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[16] && GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life != 3)
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life++;
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2] = " ";
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2] = " ";
        int i = menu2 + 1;
        GameObject.Find("slot" + i.ToString()).GetComponent<TMPro.TextMeshProUGUI>().text = "- ";
    }

    void Comp_usage()
    {
        if (inselect && attack) {
            newpos = GameObject.Find("Player").transform.position;
            if (timer > 0.005f && !back)
            {
                if (GameObject.Find("Player").transform.position.x <= -2f)
                {
                    timer = 0;
                    newpos.x += 0.1f;
                }
                else
                {
                }
            }
            if (timer > 0.01f && !back)
            {
                textplayer.SetActive(true);
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies[menu2] == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[0] && !diddps)
                {
                    GameObject.Find("talk_player").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[0];
                    int i = select + 1;
                    GameObject.Find("Ennemie" + i.ToString()).GetComponent<Ennemie_Stat>().TakeDamage(100);
                    diddps = true;
                }
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies[menu2] == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[1] && !diddps)
                {
                    GameObject.Find("talk_player").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[1];
                    int i = select + 1;
                    GameObject.Find("Ennemie" + i.ToString()).GetComponent<Ennemie_Stat>().TakeDamage(30);
                    diddps = true;
                }
                if (timer > 0.1f)
                {
                    
                }
                if (timer > 0.8f)
                {
                    textplayer.SetActive(false);
                    back = true;
                    timer = 0;
                }
            }
            if (timer > 0.005f && back)
            {
                if (GameObject.Find("Player").transform.position.x >= -6.9f)
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else
                {
                    GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
                    menu2 = 0;
                    menu1 = 0;
                    diddps = false;
                    incomp = false;
                    GameObject.Find("murphy").GetComponent<SpriteRenderer>().flipX = true;
                    comp.SetActive(false);
                    fleche1.SetActive(false);
                    attack = false;
                    inselect = false;
                    select = 0;
                    back = false;
                    myturn = false;
                }
            }
            GameObject.Find("Player").transform.position = newpos;
        }
    }

    void Q_Imput()
    {
        if (menu2 == 0 && incomp && !inselect)
        {
            menu2 = 0;
            GameObject.Find("murphy").GetComponent<SpriteRenderer>().flipX = true;
            incomp = false;
            GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
            comp.SetActive(false);
            if (menu1 != 0) {
                menu1 -= 1;
            }
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
            ininv = false;
            GameObject.Find("murphy").GetComponent<SpriteRenderer>().flipX = true;
            GameObject.Find("murphy").transform.position += new Vector3(0.0f, 0.3f * menu2, 0.0f);
            GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
            menu2 = 0;
            inv.SetActive(false);
           /* if (menu1 != 0) {
                menu1 -= 1;
                GameObject.Find("murphy").transform.position += new Vector3(0.0f, 0.3f, 0.0f);
            }*/
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
            {
                select--;
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
                    while (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
                        if (select != 0)
                            select--;
                        else
                            select = selectmax;
            }
            else
            {
                select = selectmax;
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0] == "0")
                    while (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
                        if (select != 0)
                            select--;
                        else
                            select = selectmax;
            }
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

    void D_Imput()
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
            } else
            {
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] != "0")
            {
                fleche3.SetActive(false);
            }
            else
            {
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] != "0")
            {
                fleche4.SetActive(false);
            }
            else
            {
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] != "0")
            {
                fleche5.SetActive(false);
            }
            else
            {
            }
            if (select != selectmax)
            {
                select++;
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
                    while (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
                        if (select != selectmax)
                            select++;
                        else
                            select = 0;
            }
            else
            {
                select = 0;
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0] == "0")
                    while (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
                        if (select != selectmax)
                            select++;
                        else
                            select = 0;
            }
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

    void Z_Imput()
    {
        if (incomp && !inselect)
        {
        }
        else if (ininv && menu2 != 0)
        {
            menu2 -= 1;
            GameObject.Find("murphy").transform.position += new Vector3(0.0f, 0.3f, 0.0f);
            GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
        }
        else if (ininv)
        {
        }
        else if (!incomp && !ininv)
        {
            if (menu1 != 0) {
                menu1 -= 1;
                GameObject.Find("murphy").transform.position += new Vector3(0.0f, 0.4f, 0.0f);
            }
            if (menu1 == 0)
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[28];
            if (menu1 == 1)
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[29];
            if (menu1 == 2)
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[30];
        }
    }

    void S_Imput()
    {
        if (incomp && !inselect)
        {
        }
        else if (ininv && menu2 != 5)
        {
            menu2 += 1;
            GameObject.Find("murphy").transform.position -= new Vector3(0.0f, 0.3f, 0.0f);
            GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
        }
        else if (ininv)
        {
        }
        else if (!incomp && !ininv)
        {
            if (menu1 != 2) {
                menu1 += 1;
                GameObject.Find("murphy").transform.position -= new Vector3(0.0f, 0.4f, 0.0f);
            }
            if (menu1 == 0)
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[28];
            if (menu1 == 1)
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[29];
            if (menu1 == 2)
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[30];
        }
    }

    void E_Imput()
    {
        if (ininv && GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2] != " ")
        {
            Object_usage();
            ininv = false;
            GameObject.Find("murphy").GetComponent<SpriteRenderer>().flipX = true;
            GameObject.Find("murphy").transform.position += new Vector3(0.0f, 0.4f * menu1, 0.0f);
            GameObject.Find("murphy").transform.position += new Vector3(0.0f, 0.3f * menu2, 0.0f);
            inv.SetActive(false);
            GameObject.Find("talk").transform.position = new Vector3(0.0f, 3.796653f, 0f);
            menu2 = 0;
            menu1 = 0;
            myturn = false;
        }
        else if (incomp && inselect == false && GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies[menu2] != " ")
        {
            inselect = true;
            select = 0;
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
                while (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[select] == "0")
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
        else if (inselect)
        {
            attack = true;
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] != "0")
                fleche2.SetActive(false);
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] != "0")
                fleche3.SetActive(false);
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] != "0")
                fleche4.SetActive(false);
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] != "0")
                fleche5.SetActive(false);
        }
        else if (menu1 == 0 || menu1 == 1)
        {
            GameObject.Find("talk").transform.position = new Vector3(3.7f, 3.796653f, 0f);
            if (menu1 == 0)
            {
                textcomp.SetActive(true);
                incomp = true;
                GameObject.Find("murphy").GetComponent<SpriteRenderer>().flipX = false;
                comp.SetActive(true);
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competenciesText[menu2];
                GameObject.Find("competence Texte").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().competencies[menu2];
            }
            if (menu1 == 1)
            {
                GameObject.Find("description").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
                ininv = true;
                GameObject.Find("murphy").GetComponent<SpriteRenderer>().flipX = false;
                inv.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life == 0)
        {
            life1.SetActive(false);
            life2.SetActive(false);
            life3.SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life == 1)
        {
            life1.SetActive(true);
            life2.SetActive(false);
            life3.SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life == 2)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life == 3)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(true);
        }
        if (myturn && GameObject.Find("dialogue").GetComponent<talk_battle>().dialognb == -1)
        {
            Comp_usage();
            if (Input.GetKeyDown(KeyCode.E))
            {
                E_Imput();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Q_Imput();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                D_Imput();
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Z_Imput();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                S_Imput();
            }
        }
    }
}
