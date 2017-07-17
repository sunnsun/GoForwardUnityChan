using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -0.2f;

    private float deadline = -10f;







    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed, 0, 0);
        if (this.transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }


    }
}

