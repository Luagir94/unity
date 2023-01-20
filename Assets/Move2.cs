using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float xValue = 0f;
    public float yValue = 0f;
    public float zValue = 0f;
    public float speed =0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(xValue, yValue, zValue);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
