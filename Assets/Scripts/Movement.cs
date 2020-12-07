//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//public class Movement : MonoBehaviour
//{
//    [SerializeField] private float ver, hor;
//    [SerializeField] private float speed = 10f;
//    public int jumpForce;
//    public bool isGround = true;
//    Rigidbody rb;
//    public float thrust = 1.0f;


//    public void Start()
//    {
//        rb = GetComponent<Rigidbody>();
     
//    }

//    void FixedUpdate()
//    {
//        MovePlayer();
//    }

//    void MovePlayer()
//    {
//        ver = Input.GetAxis("Vertical") * Time.deltaTime * speed;
//        hor = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
//        transform.Translate(hor, 0, ver);
//        if (isGround && Input.GetKeyDown(KeyCode.Space))
//        {
//            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
//            isGround = false;
//        }
//    }

//    private void OnCollisionEnter(Collision collision)
//    {
//        if(collision.gameObject.tag == "Ground")
//        {
//            isGround = true;
//        }
//    }
//}
