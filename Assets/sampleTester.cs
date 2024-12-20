using UnityEngine;

public class sampleTester : MonoBehaviour
{
    int moveSpeed = 20;
    float boostSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("I'm printing to the console.");
       
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * 80f * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime * boostSpeed;
        transform.Rotate(0,0,steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost")
        {
            boostSpeed = 10f;
        }
        
    }
    
    void OnCollisionEnter2D(Collision2D other) {
            boostSpeed = 1f;
    }
}
