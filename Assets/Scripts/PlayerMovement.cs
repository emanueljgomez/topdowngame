using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables
    private float playerSpeed = 5.0f;
    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //Player to move left, right, up, down
        transform.Translate(Vector3.right * x * Time.deltaTime * playerSpeed);
        transform.Translate(Vector3.forward * y * Time.deltaTime * playerSpeed);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

    }
}
