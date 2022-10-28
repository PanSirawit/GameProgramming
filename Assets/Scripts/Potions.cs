using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour
{
    [SerializeField] private int Healthpower;
    [SerializeField] private float Healthduration;
    [SerializeField] private int Manapower;
    [SerializeField] private float Manaduration;
    [SerializeField] private int Poisonpower;
    [SerializeField] private float Poisonduration;
    [SerializeField] private Affect affect;
    [SerializeField] private PotionType type;
    
    private enum PotionType
    {
        Regeneration,
        Poison,
        Mana,
        FireResistance,
        Strength,
        Flame
    }

    private void UsePotion()
    {
        switch (type)
        {
            case PotionType.Regeneration:
                affect.HealthBuff(Healthpower, Healthduration);
                break;
            case PotionType.Poison:
                affect.PoisonS(Poisonpower, Poisonduration);
                break;
            case PotionType.Mana:
                affect.Stamina(Manapower, Manaduration);
                break;
            case PotionType.FireResistance:
                break;
            case PotionType.Strength:
                break;
            case PotionType.Flame:
                break;
        }
    }
    private GameProgramming playerinput;
    private void Awake()
    {
        playerinput = new GameProgramming();
    }
    private void OnEnable()
    {
        playerinput.Enable();
    }
    private void OnDisable()
    {
        playerinput.Disable();
    }
    private void Start()
    {
        playerinput.Player.Interact.started += _ => UsePotion();
    }
}
