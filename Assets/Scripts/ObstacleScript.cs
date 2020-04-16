using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public GameObject backgroundPos;

    void Start()
    {
        
    }

    void ObstacleMove(){
        Vector2 pos;
        pos = new Vector2(0, transform.position.y + backgroundPos.transform.position.y);
    }

    
    void Update()
    {
        ObstacleMove();
    }
}
