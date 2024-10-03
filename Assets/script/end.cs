using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "Player")
        {
            SceneManager.LoadScene("end");
        }
    }
}
        