using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] int VelocidadX;
    [SerializeField] int VelocidadY;
    float yaw;
    float pitch;
    void Update()
    {
        //Movimiento camara
        yaw += VelocidadX * Input.GetAxis("Mouse X");
        pitch -= VelocidadY * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0);
    }
}
