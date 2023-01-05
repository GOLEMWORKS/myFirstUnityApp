using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("�������� ���������")]
    public float Speed = 7.0f;

    [Header("���� ������")]
    public float jumpPower = 200f;

    [Header("���������� ��������� �� �����")]
    public bool ground;

    [Header("��������� ���������")]
    public float boostPower = 2;

    public Rigidbody rb;
    void Update()
    {
        GetInputKey();
    }

    private void GetInputKey()
    {
       
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * Speed * Time.deltaTime * boostPower;
            }
            else
            {
                transform.localPosition += transform.forward * Speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if(ground == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }
}
