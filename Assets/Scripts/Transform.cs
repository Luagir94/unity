using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    public float transformFactor = 2f;
    void DoubleSize() {
    transform.localScale *= transformFactor;
}
    // Start is called before the first frame update
    void Start()
    {
        DoubleSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
