using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class intro_script : MonoBehaviour
{
    public GameObject dialog;
    public int dialogtext;
    public Sprite[] spriteArray;
    // Start is called before the first frame update
    void Start()
    {
        dialogtext = 0;
        dialog = GameObject.Find("dialogue");
        dialog.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            dialog.SetActive(true);
            /*GameObject.Find("Perso1").GetComponent<SpriteRenderer>().sprite = GameObject.Find("PNG").GetComponent<SpriteRenderer>().sprite;
            GameObject.Find("Perso2").GetComponent<SpriteRenderer>().sprite = GameObject.Find("PNG").GetComponent<SpriteRenderer>().sprite;
            GameObject.Find("fond_intro").GetComponent<SpriteRenderer>().sprite = GameObject.Find("PNG").GetComponent<SpriteRenderer>().sprite;*/
            //GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().dialog.SetActive(true);
            if (dialogtext == 0)
            {
                GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Cranium";
                GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[43];
                dialogtext++;
                
            }
            else if (dialogtext == 1)
            {
                GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Bernard";
                GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[44];
                dialogtext++;
            }
            else if (dialogtext == 2)
            {
                GameObject.Find("Nom").GetComponent<TMPro.TextMeshProUGUI>().text = "Cranium";
                GameObject.Find("textedialog").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[45];
                dialogtext++;
            }
            else if (dialogtext == 3)
            {
                //GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().dialog.SetActive(false);
                SceneManager.LoadScene("shenty_town");
            }
        }
    }
}
