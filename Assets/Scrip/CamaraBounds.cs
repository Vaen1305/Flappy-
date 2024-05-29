using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraBounds : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bird"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }

        else if (other.CompareTag("Muro"))
        {
            Destroy(other.gameObject);

        }
    }
}
