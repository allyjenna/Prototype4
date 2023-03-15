using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mushroom"))
        {
            SceneManager.LoadScene(1);
        }
        else if (other.CompareTag("Moon"))
        {
            SceneManager.LoadScene(2);
        }
        else if (other.CompareTag("Forest"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
