using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("nothing happened");
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
