using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8f;
    //public float jForce = 300f;
    public Animator animator;
    public float hor;
    public float vert;



    //private bool canJump;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));

        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("up"))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        //if (Input.GetKeyDown("space") && canJump)
        //{
        //    GetComponent<Rigidbody>().AddForce(0, jForce, 0);
        //    canJump = false;
        //}

    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "Floor")
    //    {
    //        canJump = true;
    //    }
    //}
}
