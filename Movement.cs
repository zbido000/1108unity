using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float moveSpeedOne;
    float moveSpeedTwo;

    bool isitSo;
    Rigidbody Collider;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeedOne = 5f;
        Collider = GetComponent<Rigidbody>();
        moveSpeedTwo = 5f;
        isitSo = true;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeedOne * Time.deltaTime, 0, 0);





        if (transform.position.x <= -31.5f)
        {

            moveSpeedOne = 0f;
            isitSo = false;
                

            moveSpeedTwo = 5f;




        }

        if (transform.position.x >= 43f)
        {

            moveSpeedTwo = 0f;
            isitSo = true;
            moveSpeedOne = -5f;



        }

        if (isitSo == true)
        {


            transform.Translate(moveSpeedOne * Time.deltaTime, 0, 0);

        }

        if (isitSo == false)
        {

            transform.Translate(moveSpeedTwo * Time.deltaTime, 0, 0);

        }


    }

} 
        