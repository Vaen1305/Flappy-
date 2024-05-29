using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuboControler : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bird"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;

            rb.AddForce(Vector3.left * 10f, ForceMode.Impulse);
            float yOffset = other.transform.position.y - transform.position.y;
            rb.AddForce(Vector3.up * yOffset, ForceMode.Impulse);
        }
    }
}
