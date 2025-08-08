using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    int score;
    int coinValue = 25;
    int coinsCollected = 3;


    void Start()
    {
        //Activity 1
        score = coinValue * coinsCollected;
        print("Total Score is " + score);

        //Activity 2
        bool hasKey = false;
        if (hasKey == true)
        {
            print("Door is unlocked.");
        }
        if (hasKey == false)
        {
            print("Find the key first");
        }

        //Activity 3
        int playerHealth = 100;
        int damageTaken = 30;
        playerHealth -= damageTaken;
        Debug.Log("Player Health: " + playerHealth);

        //Activity 4 

    }


    public float rotationSpeed = 45f;
    void Update()
    {
        //Activity 4

        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}

   
