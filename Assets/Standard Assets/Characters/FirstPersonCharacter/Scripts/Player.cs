using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    public float speed;
    public TMP_Text countText;
    public TMP_Text winText;

    //private Rigidbody rb;
    private int count;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    //void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");

    //    Vector3 movemwnt = new Vector3(moveHorizontal, 0.0f, moveVertical);

    //    rb.AddForce(movemwnt * speed);
    //}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggerdetected" + other.gameObject.name);
        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 32)
        {
            winText.text = "Congratulations You Win! Thank You For Playing.";
        }
    }

}