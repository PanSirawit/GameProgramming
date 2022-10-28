using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class Melee : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private int damage;
    [SerializeField] private Transform face;
    private RaycastHit hit;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(face.position, face.forward, out hit, distance))
            {
                if (hit.transform.tag == "Enemy")
                {
                    Enemy enemy;
                    

                    enemy = hit.transform.GetComponent<Enemy>();

                    enemy.TakeDamage(damage);
                }
            }
        }
    }
}
