using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie_Script : MonoBehaviour
{
    public GameObject ennemie1;
    public GameObject ennemie2;
    public GameObject ennemie3;
    public GameObject ennemie4;
    public GameObject ennemie5;
    int nb;

    // Start is called before the first frame update
    void Start()
    {
        ennemie1 = GameObject.Find("Ennemie1");
        GameObject.Find("NomEnnemie1").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[0];
        ennemie2 = GameObject.Find("Ennemie2");
        GameObject.Find("NomEnnemie2").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1];
        ennemie3 = GameObject.Find("Ennemie3");
        GameObject.Find("NomEnnemie3").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2];
        ennemie4 = GameObject.Find("Ennemie4");
        GameObject.Find("NomEnnemie4").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3];
        ennemie5 = GameObject.Find("Ennemie5");
        GameObject.Find("NomEnnemie5").GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4];
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[1] == "0")
        {
            ennemie2.SetActive(false);
            nb++;
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[2] == "0")
        {
            ennemie3.SetActive(false);
            nb++;
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[3] == "0")
        {
            ennemie4.SetActive(false);
            nb++;
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie[4] == "0")
        {
            ennemie5.SetActive(false);
            nb++;
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
