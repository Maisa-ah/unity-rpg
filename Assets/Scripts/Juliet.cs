using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Juliet : MonoBehaviour
{
    public float speed = 6f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

    }
}
