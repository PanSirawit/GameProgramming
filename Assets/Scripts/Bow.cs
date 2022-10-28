using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Rigidbody arrowModel;
    public float chargelimit;
    public float chargePower;
    public float chargeSpeed;
    public bool isCharge;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isCharge = true;
        }
        if (isCharge && chargePower <= chargelimit)
        {
            chargePower += chargeSpeed * Time.deltaTime;
        }
        if (isCharge && Input.GetMouseButtonUp(0))
        {
            Rigidbody shotArrow = Instantiate(arrowModel, transform.position, transform.rotation);
            
            shotArrow.AddForce(transform.forward * chargePower, ForceMode.Impulse); 
            
            chargePower = 0f;
            isCharge = false;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            for(int i = 0; i < 20; i++)
            {
                Rigidbody shotArrow = Instantiate(arrowModel, transform.position, transform.rotation);
            }
        }
    }
}
