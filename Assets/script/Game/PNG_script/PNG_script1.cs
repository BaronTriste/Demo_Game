using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNG_script1 : MonoBehaviour
{
    public GameObject text;
    public bool incollition;
    public int dialogtext;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("alert1");
        text.SetActive(false);
        incollition = false;
        dialogtext = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().indialog)
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
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text.SetActive(true);
            incollition = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text.SetActive(false);
            incollition = false;
        }
    }
}
