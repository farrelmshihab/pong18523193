using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 30;

    public Rigidbody2D ball;

    public Animator animtr;
    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(-1, -1) * speed;
        animtr.SetBool("ItsMove", true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ball.velocity.x > 0){//bola bergerak ke kanan
            ball.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }else{
            ball.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "DindingKanan" || other.collider.name == "DindingKiri")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
            StartCoroutine(Pause());
        }
    }
    IEnumerator Pause()
    {
        ball.velocity = Vector2.zero;
        animtr.SetBool("ItsMove", false);
        ball.GetComponent < Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);
        ball.velocity = new Vector2(-1, -1) * speed;
        animtr.SetBool("ItsMove", true);
    }


}
