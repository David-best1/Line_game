using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class StaticEnemy : MonoBehaviour
{
    [field: SerializeField] public float Damage { get; private set; }
    public bool CanDamage { get; private set; }
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        CanDamage = true;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
