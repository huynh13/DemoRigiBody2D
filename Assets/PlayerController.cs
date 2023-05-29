using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;

    public GameObject skill;
    // Start is called before the first frame update
    private Rigidbody2D rigi;
    void Start()
    {
        anim = GetComponent<Animator>(); 
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigi.AddForce(Vector2.up * 300f);
            // tác dụng 1 lực theo chiều up vào nhân vật 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetInteger("status", 1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetInteger("status", 2);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 newPositon = new Vector3(transform.position.x + 1,transform.position.y,
                transform.position.z);
            Instantiate(skill, newPositon, Quaternion.identity);
        }

      


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 6f * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 6f * Time.deltaTime);
        }
        else
        {
           // anim.SetInteger("status", 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Bull"))
        {
          Destroy(col.gameObject);   
        }
        if (col.gameObject.name.Equals("Pandora"))
        {
            Destroy(col.gameObject);   
        }

    
        if (col.gameObject.name.Equals("trap"))
        {
            Debug.Log(col.gameObject.name);
            //Destroy(gameObject);
            anim.SetInteger("status",4);
        }
    }
}