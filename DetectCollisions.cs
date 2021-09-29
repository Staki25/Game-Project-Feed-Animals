using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private static int score = 0;
    private GameManager gameManager;

    public static int Score
    {
        get { return score; }
        set { score = value; }
    }
    public int playerLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameManager);
        }
        else if (other.CompareTag("Enemy"))
        {           
            Destroy(gameObject);          
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
        }         
    }
}
