using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField, Tooltip("Enemy's Health")] int health;
    [SerializeField, Tooltip("Enemy's Speed")] float speed;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
