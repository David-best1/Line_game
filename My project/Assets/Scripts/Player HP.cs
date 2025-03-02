using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float startHP;
    [SerializeField] private LayerMask damageLayerMask;
    [SerializeField] public TextMeshProUGUI healthText;
    public float _currHP;

    private void Awake()
    {
        _currHP = startHP;
        DrawHP();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMaskUtil.ContainsLayer(damageLayerMask, collision.gameObject))
        {
            if (collision.gameObject.TryGetComponent(out StaticEnemy enemy))
            {
                if (enemy.CanDamage)
                    GetDamage(enemy.Damage);
            }

        }
    }

    private void GetDamage(float damage)
    {
        if (_currHP > 0)
        {
            _currHP -= damage;
            healthText.text = $"HP: {_currHP}";
        }
        if (_currHP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    private void DrawHP()
    {
        healthText.text = $"HP: {_currHP}";
    }
}
