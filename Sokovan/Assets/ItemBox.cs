using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;

    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // 트리거인 콜라이더와 충돌할 대 자동으로 실행
    // Enter는 충돌을 한 그 순간
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    // Exit는 붙어 있다가 떼어질 때
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }

    }

    // Stay 충돌하고 있는 혹은 붙어있는 "동안"
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }

    }

    //// 일반 콜라이더와 충돌했을 때 자동으로 실행
    //private void OnCollisionEnter(Collision other)
    //{
    //    Debug.Log("충돌 했음");
    //}
}
