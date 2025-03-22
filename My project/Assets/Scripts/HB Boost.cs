using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBBoost : MonoBehaviour
{
    [SerializeField] float HowManyAddHP;
    [SerializeField] PlayerHP PlayerHP;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        AddHealth();
        Destroy(gameObject);
    }


    private void AddHealth()
    {

        PlayerHP._currHP += HowManyAddHP;
        PlayerHP.healthText.text = "HP: "+PlayerHP._currHP;
    }
}