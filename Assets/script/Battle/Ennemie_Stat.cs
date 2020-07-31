using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ennemie_Stat : MonoBehaviour
{
    public int hp;
    public int hpmax;
    public Image healthbar;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void UpdateHealth()
    {
        hp = Mathf.Clamp(hp, 0, hpmax);
        float amount = (float)hp / hpmax;
        healthbar.fillAmount = amount;
    }

    public void TakeDamage(int damages)
    {
        hp -= damages;
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
