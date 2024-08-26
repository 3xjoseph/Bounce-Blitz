using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed; //Set the Speed for your character

    void Update()
    {
        float xValue = (Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        float zValue = (Input.GetAxis("Vertical") * Time.deltaTime) * moveSpeed;
       
        transform.Translate(xValue, 0, zValue);
    }
}
