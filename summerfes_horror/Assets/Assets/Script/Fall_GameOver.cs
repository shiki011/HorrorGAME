using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall_GameOver : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");

        }
    }
}
