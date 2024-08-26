using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    MeshRenderer obstacleRenderer;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRenderer = GetComponent<MeshRenderer>();
    }
  
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            obstacleRenderer.material.color = Color.red;
        }
    }
}
