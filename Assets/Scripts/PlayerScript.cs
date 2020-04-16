using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour {

    float speed = 5f;
    float directionSpeed = 20f;
    Rigidbody2D rigidbody2D;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void PlayerController()
    {
        float hor = Input.GetAxis("Horizontal");
       transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(Mathf.Clamp(gameObject.transform.position.x + hor, -8f, 8f), gameObject.transform.position.y, gameObject.transform.position.z), directionSpeed * Time.deltaTime);
       //rigidbody2D.velocity = new Vector2(0, speed);
    }

 
    void Update()
    {
        PlayerController();
    }
}
