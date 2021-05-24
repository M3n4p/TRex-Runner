using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float initializationTime, timeSinceInitialization;
    public float speed;

    private void Start()
    {
        initializationTime = Time.timeSinceLevelLoad;
    }

    void Update()
    {
        timeSinceInitialization = Time.timeSinceLevelLoad - initializationTime;
        transform.Translate(new Vector3(-1.0f, 0f, 0f) * Time.deltaTime * speed, Space.World);
    }

    private void OnBecameInvisible()
    {
        if(timeSinceInitialization > 4f)
        {
            Destroy(gameObject);
        }
    }
}
