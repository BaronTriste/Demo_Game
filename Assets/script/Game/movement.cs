using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 1)
        {
            GameObject.Find("life (1)").SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().Life <= 2)
        {
            GameObject.Find("life (2)").SetActive(false);
        }
        GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().posPlayer;
        speed = 0.18f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dp = new Vector3();
        if (Input.GetKey(KeyCode.Q))
        {
            dp.x -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dp.x += speed;
        }
        transform.position += dp;
    }
}
