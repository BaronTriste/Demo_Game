using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porte_3 : MonoBehaviour
{
    public GameObject alert;
    public bool incollition;

    // Start is called before the first frame update
    void Start()
    {
        alert = GameObject.Find("alerttp4");
        alert.SetActive(false);
        incollition = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (incollition && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("Player").transform.position -= new Vector3(0.0f, 45.0f, 0.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            alert.SetActive(true);
            incollition = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            alert.SetActive(false);
            incollition = false;
        }
    }
}
