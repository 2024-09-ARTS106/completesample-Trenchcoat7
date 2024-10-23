using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;

    // Update is called once per frame
    void Update()
    {
        /*
                if (Input.GetKey(KeyCode.W)) 
                { 
                    //transform.Translate(0, 0, speed);

                    transform.position += new Vector3(0, 0, speed) * Time.deltaTime; 
                }

                if (Input.GetKey(KeyCode.S)) 
                { 
                    //transform.Translate(0, 0, -speed);

                    transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
                }

                if (Input.GetKey(KeyCode.A)) 
                { 
                    //transform.Translate(speed, 0, 0);

                    transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
                }

                if (Input.GetKey(KeyCode.D)) 
                { 
                    //transform.Translate(-speed, 0, 0);

                    transform.position += new Vector3(-speed,0,0) * Time.deltaTime;
                }
        */

        /*transform.position += new Vector3(1,0,0) * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(0, 0, 1) * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;*/

        transform.position += transform.TransformDirection(Vector3.right) * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.position += transform.TransformDirection(Vector3.forward) * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
    }
}
