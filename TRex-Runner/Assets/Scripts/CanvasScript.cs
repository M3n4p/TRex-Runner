using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
    public GameManager manager;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            manager.IsDead = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
        }
    }
}
