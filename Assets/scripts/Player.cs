using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 5.0f;
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0f, speed));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0f));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(new Vector2(0f, -speed));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0f));
        }
    }
}
