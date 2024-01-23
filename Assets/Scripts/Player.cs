using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Animation thisAnimation; 

    public int force;

    public Rigidbody rb;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y,-5, 3.35f), transform.position.z);

            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, force, 0));

            

            thisAnimation.Play();
            
        }

        if (transform.position.y < -4.45f)
        {
            SceneManager.LoadScene("GameLose");
        }


    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
