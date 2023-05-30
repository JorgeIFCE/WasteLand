using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public bool ultimaFase;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("NextScenes", 0.5f);
        }
    }

    void NextScenes()
    {
         if(ultimaFase)
         {
            SceneManager.LoadScene("Menu");
         }
         else
         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         }
    }
}
