using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour
{
    public Text UIScore;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIScore.text = "Score: " + Score;
    }

    public void OnCollisionEnter(Collision collision)
    {
        print("test");
        if (collision.gameObject.tag == "Obstacle")
        {
            Score++;
            Destroy(collision.gameObject);
        }
    }
}
