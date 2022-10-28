using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField] private HPbar HPbar;
    [SerializeField] private int maxHealth;
    [SerializeField] private int health;
    [SerializeField] private int maxMana;
    [SerializeField] private int Mana;

    void Awake()
    {
        health = maxHealth;
        HPbar.Setup(maxHealth);
    }

    public void CalculateHealth(int value)
    {
        health += value;
        if (health >= maxHealth) health = maxHealth;
        else if (health <= 0) health = 0;

        HPbar.SetValue(health);
    }
    public void CalculateMana(int value)
    {
        Mana += value;
        if (Mana >= maxMana) Mana = maxMana;
        else if (Mana <= 0) Mana = 0;
    }
    void Update()
    {
        
    }


}
