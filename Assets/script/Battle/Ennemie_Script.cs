using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ennemie_Script : MonoBehaviour
{
    public GameObject alert1;
    public GameObject alert2;
    public GameObject alert3;
    public GameObject alert4;
    public GameObject alert5;
    public float timer;
    public int nbturn;
    public bool back;
    public int nbmort;
    public bool imput;
    public Vector3 newpos;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        nbturn = 0;
        nbmort = 0;
        back = false;
        imput = false;
        alert1 = GameObject.Find("alertE1");
        alert2 = GameObject.Find("alertE2");
        alert3 = GameObject.Find("alertE3");
        alert4 = GameObject.Find("alertE4");
        alert5 = GameObject.Find("alertE5");
        alert1.SetActive(false);
        alert2.SetActive(false);
        alert3.SetActive(false);
        alert4.SetActive(false);
        alert5.SetActive(false);
        GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0];
        if (GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
        {
            GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().hp = 100;
            GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().hpmax = 100;
        }
        else if (GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
        {
            GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().hp = 150;
            GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().hpmax = 150;
        }
        else if (GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
        {
            GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().hp = 150;
            GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().hpmax = 150;
        }
        GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().healthbar = GameObject.Find("HealthbarE1").GetComponent<Image>();

        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] == "0")
        {
            GameObject.Find("Ennemie2").SetActive(false);
            nbmort++;
        }
        else
        {
            GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1];
            if (GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
            {
                GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hp = 100;
                GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hpmax = 100;
            }
            else if (GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
            {
                GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hp = 150;
                GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hpmax = 150;
            }
            else if (GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
            {
                GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hp = 30;
                GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hpmax = 30;
            }
            GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().healthbar = GameObject.Find("HealthbarE2").GetComponent<Image>();
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] == "0")
        {
            GameObject.Find("Ennemie3").SetActive(false);
            nbmort++;
        }
        else
        {
            GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2];
            if (GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
            {
                GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().hp = 100;
                GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().hpmax = 100;
            }
            else if (GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
            {
                GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().hp = 150;
                GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().hpmax = 150;
            }
            else if (GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
            {
                GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().hp = 30;
                GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().hpmax = 30;
            }
            GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().healthbar = GameObject.Find("HealthbarE3").GetComponent<Image>();
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] == "0")
        {
            GameObject.Find("Ennemie4").SetActive(false);
            nbmort++;
        }
        else
        {
            GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3];
            if (GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
            {
                GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().hp = 100;
                GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().hpmax = 100;
            }
            else if (GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
            {
                GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().hp = 150;
                GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().hpmax = 150;
            }
            else if (GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
            {
                GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().hp = 30;
                GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().hpmax = 30;
            }
            GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().healthbar = GameObject.Find("HealthbarE4").GetComponent<Image>();
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] == "0")
        {
            GameObject.Find("Ennemie5").SetActive(false);
            nbmort++;
        }
        else
        {
            GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4];
            if (GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
            {
                GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().hp = 100;
                GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().hpmax = 100;
            }
            else if (GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
            {
                GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().hp = 150;
                GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().hpmax = 150;
            }
            else if (GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
            {
                GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().hp = 30;
                GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().hpmax = 30;
            }
            GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().healthbar = GameObject.Find("HealthbarE5").GetComponent<Image>();
        }
    }

    void Squellete_attack()
    {
        if (Input.GetKey(KeyCode.S))
        {
            imput = true;
        }
        else
        {
        }
    }

    void Rat_attack()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            imput = true;
        }
        else
        {
        }
    }

    void Zombie_attack()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.Q))
        {
            imput = true;
        }
        else
        {
            // GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life -= 1;
        }
    }

    void Ennemie1()
    {
        newpos = GameObject.Find("Ennemie1").transform.position;
        GameObject.Find("Event Text").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[32];
        if (!back)
        {
            if (timer > 0.007f)
            {
                if (GameObject.Find("Ennemie1").transform.position.y >= -1.5f)
                {
                    timer = 0;
                    newpos.y -= 0.1f;
                }
                else if (GameObject.Find("Ennemie1").transform.position.x >= -4.5f && GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11] || GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else if (GameObject.Find("Ennemie1").transform.position.x >= -2f)
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else
                {
                }
            }
            if (timer > 0.1f)
            {
                alert1.SetActive(true);
                if (GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
                    Squellete_attack();
                else if (GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
                    Zombie_attack();
                else if (GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                    Rat_attack();
            }
            if (timer > 0.3f)
            {
                timer = 0;
                if (!imput)
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life -= 1;
                alert1.SetActive(false);
                back = true;
            }
        }
        else if (back)
        {
            GameObject.Find("Ennemie1").GetComponent<SpriteRenderer>().flipX = true;
            if (timer > 0.007f)
            {
                if (GameObject.Find("Ennemie1").transform.position.x <= 2.1f)
                {
                    timer = 0;
                    newpos.x += 0.1f;
                }
                else if (GameObject.Find("Ennemie1").transform.position.y <= -2.7f)
                {
                    timer = 0;
                    newpos.y += 0.1f;
                }
                else
                {
                    GameObject.Find("Ennemie1").GetComponent<SpriteRenderer>().flipX = false;
                    back = false;
                    imput = false;
                    nbturn++;
                }
            }
        }
        GameObject.Find("Ennemie1").transform.position = newpos;
    }

    void Ennemie2()
    {
        newpos = GameObject.Find("Ennemie2").transform.position;
        GameObject.Find("Event Text").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[32];
        if (!back)
        {
            if (timer > 0.007f)
            {
                if (GameObject.Find("Ennemie2").transform.position.y >= -2.5f)
                {
                    timer = 0;
                    newpos.y -= 0.1f;
                }
                else if (GameObject.Find("Ennemie2").transform.position.x >= -4.5f && GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11] || GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else if (GameObject.Find("Ennemie2").transform.position.x >= -2f)
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else
                {
                }
            }
            if (timer > 0.1f)
            {
                alert2.SetActive(true);
                if (GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
                    Squellete_attack();
                else if (GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
                    Zombie_attack();
                else if (GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                    Rat_attack();
            }
            if (timer > 0.3f)
            {
                timer = 0;
                if (!imput)
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life -= 1;
                alert2.SetActive(false);
                back = true;
            }
        }
        else if (back)
        {
            GameObject.Find("Ennemie2").GetComponent<SpriteRenderer>().flipX = true;
            if (timer > 0.007f)
            {
                if (GameObject.Find("Ennemie2").transform.position.x <= 3.6f)
                {
                    timer = 0;
                    newpos.x += 0.1f;
                }
                else if (GameObject.Find("Ennemie2").transform.position.y <= -1.5f)
                {
                    timer = 0;
                    newpos.y += 0.1f;
                }
                else
                {
                    GameObject.Find("Ennemie2").GetComponent<SpriteRenderer>().flipX = false;
                    back = false;
                    imput = false;
                    nbturn++;
                }
            }
        }
        GameObject.Find("Ennemie2").transform.position = newpos;
    }

    void Ennemie3()
    {
        newpos = GameObject.Find("Ennemie3").transform.position;
        GameObject.Find("Event Text").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[32];
        if (!back)
        {
            if (timer > 0.007f)
            {
                if (GameObject.Find("Ennemie3").transform.position.y <= -2.8f)
                {
                    timer = 0;
                    newpos.y += 0.1f;
                }
                else if (GameObject.Find("Ennemie3").transform.position.x >= -4.5f && GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11] || GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else if (GameObject.Find("Ennemie3").transform.position.x >= -2f)
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else
                {
                }
            }
            if (timer > 0.1f)
            {
                alert3.SetActive(true);
                if (GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
                    Squellete_attack();
                else if (GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
                    Zombie_attack();
                else if (GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                    Rat_attack();
            }
            if (timer > 0.3f)
            {
                timer = 0;
                if (!imput)
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life -= 1;
                alert3.SetActive(false);
                back = true;
            }
        }
        else if (back)
        {
            GameObject.Find("Ennemie3").GetComponent<SpriteRenderer>().flipX = true;
            if (timer > 0.007f)
            {
                if (GameObject.Find("Ennemie3").transform.position.x <= 3.6f)
                {
                    timer = 0;
                    newpos.x += 0.1f;
                }
                else if (GameObject.Find("Ennemie3").transform.position.y >= -3.7f)
                {
                    timer = 0;
                    newpos.y -= 0.1f;
                }
                else
                {
                    GameObject.Find("Ennemie3").GetComponent<SpriteRenderer>().flipX = false;
                    back = false;
                    imput = false;
                    nbturn++;
                }
            }
        }
        GameObject.Find("Ennemie3").transform.position = newpos;
    }

    void Ennemie4()
    {
        newpos = GameObject.Find("Ennemie4").transform.position;
        GameObject.Find("Event Text").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[32];
        if (!back)
        {
            if (timer > 0.005f)
            {
                if (GameObject.Find("Ennemie4").transform.position.y >= -2.5f)
                {
                    timer = 0;
                    newpos.y -= 0.1f;
                }
                else if (GameObject.Find("Ennemie4").transform.position.x >= -4.5f && GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11] || GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else if (GameObject.Find("Ennemie4").transform.position.x >= -2f)
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else
                {
                }
            }
            if (timer > 0.1f)
            {
                alert4.SetActive(true);
                if (GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
                    Squellete_attack();
                else if (GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
                    Zombie_attack();
                else if (GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                    Rat_attack();
            }
            if (timer > 0.3f)
            {
                timer = 0;
                if (!imput)
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life -= 1;
                alert4.SetActive(false);
                back = true;
            }
        }
        else if (back)
        {
            GameObject.Find("Ennemie4").GetComponent<SpriteRenderer>().flipX = true;
            if (timer > 0.005f)
            {
                if (GameObject.Find("Ennemie4").transform.position.x <= 6f)
                {
                    timer = 0;
                    newpos.x += 0.1f;
                }
                else if (GameObject.Find("Ennemie4").transform.position.y <= -1.5f)
                {
                    timer = 0;
                    newpos.y += 0.1f;
                }
                else
                {
                    GameObject.Find("Ennemie4").GetComponent<SpriteRenderer>().flipX = false;
                    back = false;
                    imput = false;
                    nbturn++;
                }
            }
        }
        GameObject.Find("Ennemie4").transform.position = newpos;
    }

    void Ennemie5()
    {
        newpos = GameObject.Find("Ennemie5").transform.position;
        GameObject.Find("Event Text").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[32];
        if (!back)
        {
            if (timer > 0.005f)
            {
                if (GameObject.Find("Ennemie5").transform.position.y <= -2.8f)
                {
                    timer = 0;
                    newpos.y += 0.1f;
                }
                else if (GameObject.Find("Ennemie5").transform.position.x >= -4.5f && GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11] || GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else if (GameObject.Find("Ennemie5").transform.position.x >= -2f)
                {
                    timer = 0;
                    newpos.x -= 0.1f;
                }
                else
                {
                }
            }
            if (timer > 0.1f)
            {
                alert5.SetActive(true);
                if (GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10])
                    Squellete_attack();
                else if (GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11])
                    Zombie_attack();
                else if (GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[12])
                    Rat_attack();
            }
            if (timer > 0.3f)
            {
                timer = 0;
                if (!imput)
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life -= 1;
                alert5.SetActive(false);
                back = true;
            }
        }
        else if (back)
        {
            GameObject.Find("Ennemie5").GetComponent<SpriteRenderer>().flipX = true;
            if (timer > 0.005f)
            {
                if (GameObject.Find("Ennemie5").transform.position.x <= 6f)
                {
                    timer = 0;
                    newpos.x += 0.1f;
                }
                else if (GameObject.Find("Ennemie5").transform.position.y >= -3.7f)
                {
                    timer = 0;
                    newpos.y -= 0.1f;
                }
                else
                {
                    GameObject.Find("Ennemie5").GetComponent<SpriteRenderer>().flipX = false;
                    imput = false;
                    back = false;
                    nbturn++;
                }
            }
        }
        GameObject.Find("Ennemie5").transform.position = newpos;
    }

    void FixedUpdate()
    {
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0] != "0")
        {
            if (GameObject.Find("Ennemie1").GetComponent<Ennemie_Stat>().hp <= 0)
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0] = "0";
                GameObject.Find("NomEnnemie1").SetActive(false);
                GameObject.Find("HealthbarE1").SetActive(false);
                nbmort++;
            }
        }
        if (GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hp <= 0 && GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] != "0")
        {
            if (GameObject.Find("Ennemie2").GetComponent<Ennemie_Stat>().hp <= 0)
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] = "0";
                GameObject.Find("NomEnnemie2").SetActive(false);
                GameObject.Find("HealthbarE2").SetActive(false);
                nbmort++;
            }
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] != "0")
        {
            if (GameObject.Find("Ennemie3").GetComponent<Ennemie_Stat>().hp <= 0)
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] = "0";
                GameObject.Find("NomEnnemie3").SetActive(false);
                GameObject.Find("HealthbarE3").SetActive(false);
                nbmort++;
            }
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] != "0")
        {
            if (GameObject.Find("Ennemie4").GetComponent<Ennemie_Stat>().hp <= 0)
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] = "0";
                GameObject.Find("NomEnnemie4").SetActive(false);
                GameObject.Find("HealthbarE4").SetActive(false);
                nbmort++;
            }
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] != "0")
        {
            if (GameObject.Find("Ennemie5").GetComponent<Ennemie_Stat>().hp <= 0)
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] = "0";
                GameObject.Find("NomEnnemie5").SetActive(false);
                GameObject.Find("HealthbarE5").SetActive(false);
                nbmort++;
            }
        }
        if (nbmort >= 5)
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().ennemieG[GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().nbActualFigth] = 1;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().toload = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().map[GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().location];
            SceneManager.LoadScene("load_sceane");
        }

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Battle>().myturn == false)
        {
            timer += Time.deltaTime;
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0] != "0" && nbturn == 0)
            {
                Ennemie1();
            }
            else if (nbturn == 0)
            {
                nbturn++;
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] != "0" && nbturn == 1)
            {
                Ennemie2();
            }
            else if (nbturn == 1)
            {
                nbturn++;
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] != "0" && nbturn == 2)
            {
                Ennemie3();
            }
            else if (nbturn == 2)
            {
                nbturn++;
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] != "0" && nbturn == 3)
            {
                Ennemie4();
            }
            else if (nbturn == 3)
            {
                nbturn++;
            }
            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] != "0" && nbturn == 4)
            {
                Ennemie5();
            }
            else if (nbturn == 4)
            {
                nbturn++;
            }
        }
        if (nbturn == 5)
        {
            nbturn = 0;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Battle>().myturn = true;
        }
    }
}
