using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 50f;
    public bool isRightRotate = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isRightRotate)
        {
            transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Rotate(0f, -rotateSpeed * Time.deltaTime, 0f);

        }
    }
}
