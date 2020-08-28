using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnnemieTrigger : MonoBehaviour
{
    public string[] battleEnnemie = { "", "", "", "", "" };
    void Start()
    {
        battleEnnemie[0] = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10];
        battleEnnemie[1] = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[10];
        battleEnnemie[2] = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().all_text[11];
        battleEnnemie[3] = "0";
        battleEnnemie[4] = "0";
    }   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().nbActualFigth = 0;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().battleEnnemie = battleEnnemie;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().posPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().toload = "Menu";
            SceneManager.LoadScene("load_sceane");
        }
    }
}
