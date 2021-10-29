using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Variables
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys object when it reaches top bound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        
        // Destroys object when it reaches bottom bound and gives Game Over
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
