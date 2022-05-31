using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public Vector3 ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey(KeyCode.D))
        {
            ball.x = 0.1f;
            ball.y = 0f;
            ball.z = 0f;

            transform.Translate(ball);
        }

        if(Input.GetKey(KeyCode.A))
        {
            ball.x = -0.1f;
            ball.y = 0f;
            ball.z = 0f;

            transform.Translate(ball);
        }

        if(Input.GetKey(KeyCode.S))
        {
            ball.x = 0f;
            ball.y = 0f;
            ball.z = -0.1f;

            transform.Translate(ball);
        }

        if(Input.GetKey(KeyCode.W))
        {
            ball.x = 0f;
            ball.y = 0f;
            ball.z = 0.1f;

            transform.Translate(ball);
        }
    }
}
