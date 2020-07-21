using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public GameObject dialog;
    public bool down;
    public bool up;
    public bool right;
    public bool left;

    // Start is called before the first frame update
    void Start()    
    {
        down = false;
        up = false;
        right = false;
        left = false;
        dialog = GameObject.Find("dialogue");
        dialog.SetActive(false);
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

    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dp = new Vector3();
        if (Input.GetKey(KeyCode.Q) && !left)
        {
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = true;
            dp.x -= speed;
        }
        if (Input.GetKey(KeyCode.D) && !right)
        {
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = false;
            dp.x += speed;
        }
        if (Input.GetKey(KeyCode.S) && !down)
        {
            dp.y -= speed;
        }
        if (Input.GetKey(KeyCode.Z) && !up)
        {
            dp.y += speed;
        }
        transform.position += dp;
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
