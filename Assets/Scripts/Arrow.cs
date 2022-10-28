using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private GameObject Self;
    [SerializeField] private GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            DestroyArrow();
        }
        
    }
    private void DestroyArrow()
    {
        GameObject clone = Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(Self);
    }
}
