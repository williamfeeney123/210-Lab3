using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject BallPrefab;
    public GameObject BallPrefab2;
    public GameObject BallPrefab3;
    public GameObject BallPrefab4;
    public float BallStartYPosition; //Height to spawn balls.
    public float BallStartXRange;   //Width of random ball spawn position.
    public Vector3 BoomPosition;    //Point to add force from.
    public float BoomPower;         //Add force strength.
    public float BoomFalloff;       //Strength loss over distance.

    private List<GameObject> ballList = new List<GameObject>(); //List of all spawned balls.

    //This is called by the UI button.
    public void Button_Drop()
    {
        //For loop to spawn 10 balls per call.
        for (int i = 0; i < 1f; i++)
        {
            //Instantiate at a random position, and set to temp variable for future use.
            GameObject newBall = Instantiate(BallPrefab, new Vector3(Random.Range(-BallStartXRange, BallStartXRange), BallStartYPosition, 0f), Quaternion.identity);
            ballList.Add(newBall); //Use temp varaible to add ball to list.
        }
    }

    public void Button_Drop2()
    {
        //For loop to spawn 10 balls per call.
        for (int i = 0; i < 1f; i++)
        {
            //Instantiate at a random position, and set to temp variable for future use.
            GameObject newBall = Instantiate(BallPrefab2, new Vector3(Random.Range(-BallStartXRange, BallStartXRange), BallStartYPosition, 0f), Quaternion.identity);
            ballList.Add(newBall); //Use temp varaible to add ball to list.
        }
    }

    public void Button_Drop3()
    {
        //For loop to spawn 10 balls per call.
        for (int i = 0; i < 1f; i++)
        {
            //Instantiate at a random position, and set to temp variable for future use.
            GameObject newBall = Instantiate(BallPrefab3, new Vector3(Random.Range(-BallStartXRange, BallStartXRange), BallStartYPosition, 0f), Quaternion.identity);
            ballList.Add(newBall); //Use temp varaible to add ball to list.
        }
    }

    public void Button_Drop4()
    {
        //For loop to spawn 10 balls per call.
        for (int i = 0; i < 1f; i++)
        {
            //Instantiate at a random position, and set to temp variable for future use.
            GameObject newBall = Instantiate(BallPrefab4, new Vector3(Random.Range(-BallStartXRange, BallStartXRange), BallStartYPosition, 0f), Quaternion.identity);
            ballList.Add(newBall); //Use temp varaible to add ball to list.
        }
    }

    public void Button_Clear()
    {
        //For each loop.
        foreach (GameObject ball in ballList)
        {
            Destroy(ball); //Destroy each ball in the list.
        }
        ballList.Clear(); //Clear all balls from the list.
    }

}
