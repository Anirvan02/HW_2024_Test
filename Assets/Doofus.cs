using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doofus : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool isOnGround = true;
    private Rigidbody playerRb;
    private float fallThreshold = -5.0f;  

    void Start()
    {
        moveSpeed = 5.0f;
        jumpForce = 5.0f;
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Player movement along x and z axis
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        // Player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadScene("LoseScreen"); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
