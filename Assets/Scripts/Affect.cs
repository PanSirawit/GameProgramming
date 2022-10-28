using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affect : MonoBehaviour
{
    [SerializeField] private Stat stat;
    [Header("Health Related Effects")]
    [SerializeField] private float timeBetweenHeal;
    private Coroutine healthFX;
    private float Healthduration;
    private bool healthFXinProgress;

    [SerializeField] private float timeBetweenPoison;
    private Coroutine PoisonFX;
    private float Poisonduration;
    private bool PoisonFXinProgress;

    [SerializeField] private float timeBetweenMana;
    private Coroutine ManaFX;
    private float Manaduration;
    private bool ManaFXinProgress;

    public void HealthBuff(int power, float limiter)
    {
        if (healthFX != null) StopCoroutine(healthFX);
        healthFX = StartCoroutine(Adrenaline(limiter, timeBetweenHeal, power));
    }
    public void PoisonS(int power, float limiter)
    {
        if (PoisonFX != null) StopCoroutine(PoisonFX);
        PoisonFX = StartCoroutine(Poison(limiter, timeBetweenPoison, power));
    }
    public void Stamina(int power, float limiter)
    {
        if (ManaFX != null) StopCoroutine(ManaFX);
        ManaFX = StartCoroutine(Mana(limiter, timeBetweenMana, power));
    }

    private void Update()
    {
        if(healthFXinProgress)Healthduration += Time.deltaTime;
        if (PoisonFXinProgress) Poisonduration += Time.deltaTime;
    }
    IEnumerator Adrenaline(float limiter, float timeBetweenFX, int power)
    {
        Healthduration = 0f;
        healthFXinProgress = true;
        while (Healthduration <= limiter)
        {
            
            stat.CalculateHealth(power);
            yield return new WaitForSeconds(timeBetweenFX);
            
        }
        healthFX = null;
        healthFXinProgress = false;
    }
    IEnumerator Poison(float limiter, float timeBetweenFX, int power)
    {
        Poisonduration = 0f;
        PoisonFXinProgress = true;
        while (Poisonduration <= limiter)
        {

            stat.CalculateHealth(-power);
            yield return new WaitForSeconds(timeBetweenFX);

        }
        PoisonFX = null;
        PoisonFXinProgress = false;
    }
    IEnumerator Mana(float limiter, float timeBetweenFX, int power)
    {
        Manaduration = 0f;
        ManaFXinProgress = true;
        while (Manaduration <= limiter)
        {

            stat.CalculateMana(power);
            yield return new WaitForSeconds(timeBetweenFX);

        }
        ManaFX = null;
        ManaFXinProgress = false;
    }
}
