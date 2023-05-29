using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigi;
    private int time = 0;
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time == 0)
        {
            rigi.AddForce(Vector2.right * 1000f);
        }
        time = 1;

    }
}
