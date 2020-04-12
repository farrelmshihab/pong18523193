using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class box : MonoBehaviour
{	public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity= new Vector2(-1,-1) * speed;
    }

    // Update is called once per frame
    
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.collider.name == "Kanan" || other.collider.name == "Kiri"){
            StartCoroutine(CountDown());
            GetComponent<Transform>().position = new Vector2(0,0);
            
        }
    }

    IEnumerator CountDown()
    {
        
        yield return new WaitForSeconds(1);
        
    }
}