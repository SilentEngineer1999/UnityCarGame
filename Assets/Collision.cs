using System;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(0,0,0,0);
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor; 
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) {

            if (other.CompareTag("Package") && !hasPackage)
            {
                spriteRenderer.color = hasPackageColor;
                Debug.Log("Package");
                hasPackage = true;
                Destroy(other.gameObject, 0.9f);
            }
            else if(other.CompareTag("Customer") && hasPackage)
            {
                spriteRenderer.color = noPackageColor;
                Debug.Log("Customer");
                hasPackage = false;
            }
    
        
    }
}
