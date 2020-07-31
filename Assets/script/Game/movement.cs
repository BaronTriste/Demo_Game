using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public GameObject dialog;
    public GameObject Inv;
    public GameObject Map;
    public bool inInv;
    public bool inmap;
    public bool down;
    public bool up;
    public bool right;
    public bool left;
    public GameObject life3;
    public GameObject life2;
    public GameObject life1;
    public Animator animator;

    // Start is called before the first frame update
    void Start()    
    {
        life1 = GameObject.Find("life");
        life2 = GameObject.Find("life (1)");
        life3 = GameObject.Find("life (2)");
        down = false;
        up = false;
        right = false;
        left = false;
        inInv = false;
        inmap = false;
        GameObject.Find("slot1").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[0];
        GameObject.Find("slot2").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[1];
        GameObject.Find("slot3").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[2];
        GameObject.Find("slot4").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[3];
        GameObject.Find("slot5").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[4];
        GameObject.Find("slot6").GetComponent<TMPro.TextMeshProUGUI>().text = "- " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>().inventory[5];
        dialog = GameObject.Find("dialogue");
        Inv = GameObject.Find("invotoryM");
        Map = GameObject.Find("mapi");
        Map.SetActive(false);
        Inv.SetActive(false);
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

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("PNG").GetComponent<PNG_script>().indialog)
        {
            animator.SetBool("intalk", false);
            //Vector3 dp = new Vector3();
            if (Input.GetKey(KeyCode.Q) && !left && !inInv && !inmap)
            {
                GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = true;
                transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.D) && !right && !inInv && !inmap)
            {
                GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = false;
                transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.S) && !down && !inInv && !inmap)
            {
                transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
            }
            if (Input.GetKey(KeyCode.Z) && !up && !inInv && !inmap)
            {
                transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
            }
            if (Input.GetKeyDown(KeyCode.M) && inmap && !inInv)
            {
                Map.SetActive(false);
                inmap = false;
            }
            else if (Input.GetKeyDown(KeyCode.M) && !inmap && !inInv)
            {
                Map.SetActive(true);
                inmap = true;
            }
            if (Input.GetKeyDown(KeyCode.I) && inInv && !inmap)
            {
                Inv.SetActive(false);
                inInv = false;
            }
            else if (Input.GetKeyDown(KeyCode.I) && !inmap && !inInv)
            {
                Inv.SetActive(true);
                inInv = true;
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
