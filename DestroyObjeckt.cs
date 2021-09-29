using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjeckt : MonoBehaviour
{
    public float topBound = 30.0f;
    public float lowerBound = -10f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -topBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);          
        }
        else if (transform.position.x > topBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);        
        }
        else if (transform.position.z > topBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);          
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
