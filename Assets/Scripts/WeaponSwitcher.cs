using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;
    private int WeaponQuantity;
    private int ActiveWeapon = 0;
    private int Lastweapon;  

    void Start()
    {
        WeaponQuantity = weapons.Length;
        Lastweapon = ActiveWeapon;
    }

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Lastweapon = ActiveWeapon;
            ActiveWeapon++;
            if (ActiveWeapon == WeaponQuantity) ActiveWeapon=0;

            weapons[Lastweapon].SetActive(false);
            weapons[ActiveWeapon].SetActive(true);
        }
        else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            Lastweapon = ActiveWeapon;
            ActiveWeapon--;
            if (ActiveWeapon <= -1) ActiveWeapon = WeaponQuantity - 1;

            weapons[Lastweapon].SetActive(false);
            weapons[ActiveWeapon].SetActive(true);
        }
    }
}
