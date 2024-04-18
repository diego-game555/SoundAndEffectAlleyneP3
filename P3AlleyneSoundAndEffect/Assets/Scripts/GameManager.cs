using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
    private PlayerController playerControllerscript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerscript = GameObject.Find("Player").GetComponent<PlayerController>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerscript.gameOver)
        {
            if (playerControllerscript.doubleSpeed)
            {
                score += 2;
            }
            else
            {
                score++;
            }
            Debug.Log("Score: " + score);
        }
    }
}
