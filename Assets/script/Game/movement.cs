using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    //déplacement
    public float speed;
    public bool down;
    public bool up;
    public bool right;
    public bool left;

    //menu
    public GameObject Menu;
    public int menu1;
    public int retmenu2; // object reteneur
    public int menu2;
    public string menu;
    public bool inMenu;
    public GameObject[] selector;
    public GameObject[] allMenu;


    //reste
    public GameObject dialog;
    public GameObject life3;
    public GameObject life2;
    public GameObject life1;
    public bool indialog;
    public Animator animator;

    // Start is called before the first frame update
    void Start()    
    {
        GameObject.Find("obj_talk").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[0];
        indialog = false;
        GameObject.Find("texte_btn11").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[65];
        GameObject.Find("texte_btn10").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[68];
        GameObject.Find("texte_btn9").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[66];
        GameObject.Find("texte_btn8").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[64];
        GameObject.Find("texte_btn7").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[70];
        GameObject.Find("texte_btn6").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[69];
        GameObject.Find("texte_btn5").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[68];
        GameObject.Find("texte_btn4").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[60];
        GameObject.Find("texte_btn3").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[61];
        GameObject.Find("texte_btn2").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[62];
        GameObject.Find("texte_btn1").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[63];
        selector = new GameObject[] { GameObject.Find("selector_1"), GameObject.Find("selector_2"), GameObject.Find("selector_3"), GameObject.Find("selector_4"),
        GameObject.Find("selector_5"), GameObject.Find("selector_6"), GameObject.Find("selector_7"), GameObject.Find("selector_8"), GameObject.Find("selector_9"),
        GameObject.Find("selector_10"), GameObject.Find("selector_11"), GameObject.Find("selector_12"), GameObject.Find("selector_13"), GameObject.Find("selector_14"),
        GameObject.Find("selector_15"), GameObject.Find("selector_16"), GameObject.Find("selector_inv")};
        life1 = GameObject.Find("life");
        life2 = GameObject.Find("life (1)"); 
        life3 = GameObject.Find("life (2)");
        down = false;
        up = false;
        right = false;
        left = false;
        inMenu = false;
        menu = "no menu";
        GameObject.Find("slot1").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[0];
        GameObject.Find("slot2").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[1];
        GameObject.Find("slot3").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[2];
        GameObject.Find("slot4").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[3];
        GameObject.Find("slot5").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[4];
        GameObject.Find("slot6").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[5];
        allMenu = new GameObject[] { GameObject.Find("mapi"), GameObject.Find("invotoryM"), GameObject.Find("selector_3"), GameObject.Find("menu_Option"), GameObject.Find("objet"),  GameObject.Find("Object_select"), GameObject.Find("reso_select"), GameObject.Find("option_select")};
        for (int i = 1; i != 7; i++)
            allMenu[i].SetActive(false);
        for (int i = 1; i != 16; i++)
            selector[i].SetActive(false);
        dialog = GameObject.Find("dialogue");
        Menu = GameObject.Find("pause menu");
        Menu.SetActive(false);
        dialog.SetActive(false);
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 0)
        {
            life1.SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 1)
        {
            life2.SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 2)
        {
            life3.SetActive(false);
        }
        GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().posPlayer;
        speed = 20f;
    }

    void FixedUpdate()
    {

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

    void move()
    {
        if (Input.GetKey(KeyCode.Q) && !left && !inMenu)
        {
            animator.SetBool("inrun", true);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = true;
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D) && !right && !inMenu)
        {
            animator.SetBool("inrun", true);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = false;
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.S) && !down && !inMenu)
        {
            animator.SetBool("inrun", true);
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.Z) && !up && !inMenu)
        {
            animator.SetBool("inrun", true);
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        } else {
            animator.SetBool("inrun", false);
        }

        //manette
        if (Input.GetAxis("Horizontal") == -1 && !left && !inMenu)
        {
            animator.SetBool("inrun", true);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = true;
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetAxis("Horizontal") == 1 && !right && !inMenu)
        {
            animator.SetBool("inrun", true);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = false;
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetAxis("Vertical") == -1 && !down && !inMenu)
        {
            animator.SetBool("inrun", true);
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetAxis("Vertical") == 1 && !up && !inMenu)
        {
            animator.SetBool("inrun", true);
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
    }

    void menu_fonc()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(menu == "no menu") {
                
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if(menu == "no menu") {
                
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            selector[menu1].SetActive(false);
            if(menu == "no menu") {
                if (menu1 != 3)
                    menu1++;
                else
                    menu1 = 0;
                selector[menu1].SetActive(true);
            }
            if(menu == "inventaire") {
                if (menu1 >= 4 && menu1 <= 6) {
                    selector[menu1].SetActive(false);
                    if (menu1 != 6) {
                        menu1++;
                    }
                    else {
                        menu1 = 4;
                    }
                    selector[menu1].SetActive(true);
                } else {
                    if (menu2 != 5) {
                        menu2++;
                        GameObject.Find("selector_inv").transform.position -= new Vector3(0.0f, 0.5f, 0.0f);
                    }
                    else {
                        menu2 = 0;
                        GameObject.Find("selector_inv").transform.position += new Vector3(0.0f, 2.5f, 0.0f);
                    }
                    GameObject.Find("obj_talk").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
                }
            }
            if (menu == "option") {
                if (menu1 >= 12 && menu1 <= 15) {
                    selector[menu1].SetActive(false);
                    if (menu1 != 15) {
                        menu1++;
                    }
                    else {
                        menu1 = 12;
                    }
                    selector[menu1].SetActive(true);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            selector[menu1].SetActive(false);
            if(menu == "no menu") {
                if (menu1 != 0) {
                    menu1--;
                }
                else {
                    menu1 = 3;
                }
                selector[menu1].SetActive(true);
            }
            if (menu == "inventaire") {
                if (menu1 >= 4 && menu1 <= 6) {
                    selector[menu1].SetActive(false);
                    if (menu1 != 4) {
                        menu1--;
                    }
                    else {
                        menu1 = 6;
                    }
                    selector[menu1].SetActive(true);
                } else {
                    if (menu2 != 0) {
                        menu2--;
                        GameObject.Find("selector_inv").transform.position += new Vector3(0.0f, 0.5f, 0.0f);
                    }
                    else {
                        menu2 = 5;
                        GameObject.Find("selector_inv").transform.position -= new Vector3(0.0f, 2.5f, 0.0f);
                    }
                    GameObject.Find("obj_talk").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
                }
            }
            if (menu == "option") {
                if (menu1 >= 12 && menu1 <= 15) {
                    selector[menu1].SetActive(false);
                    if (menu1 != 12) {
                        menu1--;
                    }
                    else {
                        menu1 = 15;
                    }
                    selector[menu1].SetActive(true);
                }
            }
        }

        //manette
        if (Input.GetAxis("Horizontal") == -1)
        {
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = true;
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetAxis("Horizontal") == 1)
        {
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = false;
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetAxis("Vertical") == -1)
        {
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetAxis("Vertical") == 1)
        {
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!indialog)
        {
            animator.SetBool("intalk", false);

            move();
            //clavier
            

            //gestion menu
            if (inMenu)
                menu_fonc();
            if (Input.GetKeyDown(KeyCode.Escape) && inMenu)
            {
                if (menu == "inventaire") {
                    if (menu1 >= 4 && menu1 <= 6) {
                        selector[menu1].SetActive(false);
                        selector[7].SetActive(true);
                        menu1 = 0;
                        allMenu[5].SetActive(false);
                    } else {
                        menu = "no menu";
                        selector[0].SetActive(true);
                        allMenu[1].SetActive(false);
                        allMenu[0].SetActive(true);
                        GameObject.Find("Titre").GetComponent<TMPro.TextMeshProUGUI>().text = "";
                    }
                }
               /* else if (menu == "inventaire") {
                } */
                else if (menu == "option") {

                } else {
                    Menu.SetActive(false);
                    menu1 = 0;
                    menu2 = 0;
                    inMenu = false;
                    menu = "no menu";
                }
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && !inMenu)
            {
                Menu.SetActive(true);
                inMenu = true;
                menu = "no menu";
            }
            if (Input.GetKeyDown(KeyCode.E)) {
                if(inMenu) {
                    if(menu == "no menu") {
                        if (menu1 == 3) {
                            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().toload = "Menu";
                            SceneManager.LoadScene("load_sceane");
                        } else {
                            allMenu[0].SetActive(false);
                            allMenu[menu1 + 1].SetActive(true);
                            selector[menu1].SetActive(false);
                            //menu inventaire
                            if (menu1 == 0) {
                                GameObject.Find("anonce").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[72];
                                menu = "inventaire";
                                GameObject.Find("Titre").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[60];

                            }
                            //menu underbook
                            if (menu1 == 1) {
                                menu = "underbook";
                                GameObject.Find("Titre").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[61];

                            }
                            //menu option
                            if (menu1 == 2) {
                                menu = "option";
                                menu1 = 12;
                                selector[menu1].SetActive(true);
                                GameObject.Find("Titre").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[62];

                            }
                        }
                    } else {
                        if (menu == "inventaire") {
                            if (menu1 == 0 && GameObject.Find("anonce").GetComponent<TMPro.TextMeshProUGUI>().text == GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[73]) {
                                string first = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2];
                                string second = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];
                                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2] = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[retmenu2];
                                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2] = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[retmenu2];
                                int i = menu2 + 1;
                                GameObject.Find("slot" + i.ToString()).GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2];
                                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[retmenu2] = first;
                                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[retmenu2] = second;
                                i = retmenu2 + 1;
                                GameObject.Find("slot" + i.ToString()).GetComponent<TMPro.TextMeshProUGUI>().text = "- " + first;
                                GameObject.Find("anonce").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[72];
                                GameObject.Find("obj_talk").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2];

                            } else if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2] != " " && menu1 == 0) {
                                selector[7].SetActive(false);
                                menu1 = 4;
                                selector[4].SetActive(true);
                                allMenu[5].SetActive(true);
                            } else if (menu1 >= 4 && menu1 <= 6) {
                                if (menu1 == 4) {
                                    Object_usage();
                                }
                                if (menu1 == 5) {
                                    GameObject.Find("anonce").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[73];
                                    retmenu2 = menu2;
                                }
                                if (menu1 == 6) {
                                    GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[menu2] = " ";
                                    GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventoryTexte[menu2] = " ";
                                    int i = menu2 + 1;
                                    GameObject.Find("slot" + i.ToString()).GetComponent<TMPro.TextMeshProUGUI>().text = "- ";
                                }                                
                                selector[menu1].SetActive(false);
                                selector[7].SetActive(true);
                                menu1 = 0;
                                allMenu[5].SetActive(false);
                            } else {
                                GameObject.Find("obj_talk").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[27];
                            }
                        }
                        if (menu == "option") {
                            if (menu1 == 14) {
                                selector[menu1].SetActive(false);
                                menu1 = 8;
                                allMenu[6].SetActive(true);
                                selector[menu1].SetActive(true);
                            }
                        }
                    }
                }
            }
        } else
        {
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall right")
        {
            right = true;
        }
        if (collision.gameObject.tag == "wall up")
        {
            up = true;
        }
        if (collision.gameObject.tag == "wall left")
        {
            left = true;
        }
        if (collision.gameObject.tag == "wall down")
        {
            down = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall right")
        {
            right = false;
        }
        if (collision.gameObject.tag == "wall up")
        {
            up = false;
        }
        if (collision.gameObject.tag == "wall left")
        {
            left = false;
        }
        if (collision.gameObject.tag == "wall down")
        {
            down = false;
        }
    }
    
}
