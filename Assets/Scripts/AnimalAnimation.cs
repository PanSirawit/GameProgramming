using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalAnimation : MonoBehaviour
{
    private Animator anim;
    
    // Start is called before the first frame update
    void Awake()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("iswalk", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("iswalk", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("isrun", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isrun", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("jump", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("jump", false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("death", true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            anim.SetBool("death", false);
        }
    }
}
