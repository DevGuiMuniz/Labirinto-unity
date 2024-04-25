using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float speed = 7.0f;
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
       


        Vector3 mov = new Vector3(vertical, 0, horizontal);
        controller.Move(mov);
    }
}
