using UnityEngine;

public class DamageAndHeal : MonoBehaviour
{
    public int life = 100;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Damage", 0f, 1.0f);
        InvokeRepeating("Heal", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Damage()
    {
        life -= 10;
        Debug.Log("Vida: " + life);
    }

    private void Heal()
    {
        life += 50;
        Debug.Log("Vida: " + life);
    }
}
