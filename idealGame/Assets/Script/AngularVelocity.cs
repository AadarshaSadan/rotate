using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngularVelocity : MonoBehaviour
{
    public InputField name;
    public Text getinputtext;
    public float currentAngle = 2.39f;
    public float rotateSpeed;

    public float Zaxis;

    public bool stop;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // rotateSpeed = float.Parse(name.text);
        rotateSpeed = 0.5f;
        if (stop)
        {
            currentAngle += Time.deltaTime * rotateSpeed;
            transform.rotation = Quaternion.EulerRotation(0F, 0, currentAngle);
           
        }
        Zaxis = transform.eulerAngles.z;
        if (transform.rotation.z > 50)
        {
            stop = false;
        }

    }

    public void buttonclick()
    {
        Debug.Log(float.Parse(name.text));
    }


}
