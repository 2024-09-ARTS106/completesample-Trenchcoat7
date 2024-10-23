using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMouseMovement : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject rotatePoint;
    public GameObject playerGameOBJ;

    // Update is called once per frame
    void Update()
    {



        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        /*transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);*/

        rotatePoint.transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);
        playerGameOBJ.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        Cursor.lockState = CursorLockMode.Locked;


    }
}
