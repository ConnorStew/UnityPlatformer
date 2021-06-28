using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0,0,0);
        float moveDistance = -speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            move.y -= moveDistance;
            //move = new Vector3(0, -moveDistance);
        }

        if (Input.GetKey(KeyCode.A))
        {
            move.x += moveDistance;
            //move = new Vector3(moveDistance, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            move.x -= moveDistance;
            //move = new Vector3(-moveDistance, 0);
        }

        transform.position += move;
    }
}
