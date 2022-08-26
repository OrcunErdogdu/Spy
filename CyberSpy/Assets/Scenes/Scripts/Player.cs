using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Rigidbody2D playerRigidBody;




    void Start()
    {
        
    }

    void Update()
    {
        

        float MoveH = Input.GetAxisRaw("Horizontal");
        float MoveV = Input.GetAxisRaw("Vertical");


        playerRigidBody.velocity = new Vector2(MoveH,MoveV);

        

    }
}
