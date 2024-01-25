using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float minYThreshold = -20;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }

        if (transform.position.y < minYThreshold)
        {
            BirdFalls();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

    void BirdFalls()
    {
        birdIsAlive = false;

        if (logic != null)
        {
            logic.gameOver();
        }
    }
}
