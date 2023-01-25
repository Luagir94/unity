using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10.0f;
    
    

    void Start()
    {
      
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, 0, zValue);
    }


}
