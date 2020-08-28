using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk_battle : MonoBehaviour
{
    public GameObject dialogue;
    public int dialognb;
    public int dialogtext;
    public Animator[] animator;

    void Start()
    {
        dialogue = GameObject.Find("dialogue");
        dialogue.SetActive(true);
        dialognb = 0;
        dialogtext = 0;
    }

    void Update()
    {
        if (dialognb == 0)
        {
            GameObject.Find("Perso1").GetComponent<SpriteRenderer>().sprite = GameObject.Find("Player").GetComponent<SpriteRenderer>().sprite;
            GameObject.Find("Perso2").GetComponent<SpriteRenderer>().sprite = GameObject.Find("murphy").GetComponent<SpriteRenderer>().sprite;
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (dialogtext == 0)
                {
                    GameObject.Find("dialogue").GetComponent<talk_battle>().animator[0].SetBool("intalk", true);
                    GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Murphy";
                    GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[78];
                    dialogtext++;
                }
                else if (dialogtext == 1)
                {
                    GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[79];
                    dialogtext++;
                }
                else if (dialogtext == 2)
                {
                    GameObject.Find("dialogue").GetComponent<talk_battle>().animator[0].SetBool("intalk", false);
                    GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Cranium";
                    GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[80];
                    dialogtext++;
                }
                if (dialogtext == 3)
                {
                    GameObject.Find("dialogue").GetComponent<talk_battle>().animator[0].SetBool("intalk", true);
                    GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Murphy";
                    GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[81];
                    dialogtext++;
                }
                else if (dialogtext == 4)
                {
                    GameObject.Find("dialogue").GetComponent<talk_battle>().animator[0].SetBool("intalk", false);
                    GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Cranium";
                    GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[82];
                    dialogtext++;
                }
                else if (dialogtext == 5)
                {
                    GameObject.Find("dialogue").GetComponent<talk_battle>().animator[0].SetBool("intalk", true);
                    GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Murphy";
                    GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[83];
                    dialogtext++;
                }
                else if (dialogtext == 6)
                {
                    GameObject.Find("dialogue").GetComponent<talk_battle>().animator[0].SetBool("intalk", false);
                    GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Cranium";
                    GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[84];
                    dialogtext++;
                }
                else if (dialogtext == 7)
                {
                    dialognb = -1;
                    dialogue.SetActive(false);
                    dialogtext++;
                }
            }
        }
        if (dialognb == 1) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
            } 
        }
        /*if (GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().indialog)
        {
            GameObject.Find("Perso1").GetComponent<SpriteRenderer>().sprite = GameObject.Find("PNG1").GetComponent<SpriteRenderer>().sprite;
            GameObject.Find("Perso2").GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().sprite;
        }
        if (incollition && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().indialog = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().dialog.SetActive(true);
            if (dialogtext == 0)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().animator.SetBool("intalk", true);
                GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Cranium";
                GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[43];
                dialogtext++;
            }
            else if (dialogtext == 1)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().animator.SetBool("intalk", false);
                GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Bernard";
                GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[44];
                dialogtext++;
            }
            else if (dialogtext == 2)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().animator.SetBool("intalk", true);
                GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Cranium";
                GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[45];
                dialogtext++;
            }
            else if (dialogtext == 3)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().indialog = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().dialog.SetActive(false);
                dialogtext = 0;
            }
        }*/
    }
}
