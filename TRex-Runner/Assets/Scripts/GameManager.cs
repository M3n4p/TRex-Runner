using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isDead;

    public GameObject canvas;

    public bool IsDead
    {
        get { return isDead; }
        set
        {
            if (value == isDead)
                return;
            isDead = value;
        }
    }

    private void LateUpdate()
    {
        if(isDead)
        {
            canvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
