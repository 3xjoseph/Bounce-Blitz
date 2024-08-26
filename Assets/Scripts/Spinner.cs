using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;

    MeshRenderer renderSpinner;

    void Start()
    {
        renderSpinner = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle) ;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            renderSpinner.material.color = Color.magenta;
        }
    }
}
