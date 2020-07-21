using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie_Script : MonoBehaviour
{
    int nb;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0];
        
        
        
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] == "0")
        {
            GameObject.Find("flèche2").SetActive(false);
            GameObject.Find("NomEnnemie2").SetActive(false);
            GameObject.Find("Ennemie2").SetActive(false);
            nb++;
        } else
        {
            GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1];
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] == "0")
        {
            GameObject.Find("flèche3").SetActive(false);
            GameObject.Find("NomEnnemie3").SetActive(false);
            GameObject.Find("Ennemie3").SetActive(false);
            nb++;
        }
        else
        {
            GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2];
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] == "0")
        {
            //GameObject.Find("flèche4").SetActive(false);
            //GameObject.Find("NomEnnemie4").SetActive(false);
            GameObject.Find("Ennemie4").SetActive(false);
            nb++;
        }
        else
        {
            GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3];
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] == "0")
        {   
            GameObject.Find("flèche5").SetActive(false);
            GameObject.Find("NomEnnemie5").SetActive(false);
            GameObject.Find("Ennemie5").SetActive(false);
            nb++;
        }
        else
        {
            GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4];
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Battle>().myturn == false)
        {
            for (int i = 0; i != (4 - nb); i++)
            {
                if (GameObject.FindGameObjectWithTag("Player").GetComponent<GameData>().battleEnnemie[i] != "")
                {
                    //code attack
                }
            }
        }
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Battle>().myturn = true;*/
    }
}
