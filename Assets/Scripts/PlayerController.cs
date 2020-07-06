using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
     float speed=10;
    Rigidbody rb;
    public GameObject prefab;
    private int count;
    public Text countText;
    public Text winText;
    List<Vector3> prefabPostionList;
    public TextMesh text1;
    public TextMesh text2;
    public TextMesh text3;
    public TextMesh text4;
    public TextMesh text5;
    public TextMesh text6;
    public TextMesh text7;
    public TextMesh text8;
    public TextMesh text9;
    public TextMesh text10;
   // private var characters String = "0123456789abcdefghijklmnopqrstuvwxABCDEFGHIJKLMNOPQRSTUVWXYZ";

    void Start()
    {           
        text1.text = "game2";
        rb = GetComponent<Rigidbody>();
        GeneratePrefab();
    }
    private void FixedUpdate()
    {
        float horizental = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector3 = new Vector3(horizental, 0.0f, vertical);
        rb.AddForce(vector3 * speed);     
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setTextCount();
        }
        if (count >= 10)
        {
            winText.text = "Conguralation You win the game";
        }

    }
    void setTextCount()
    {
        //countText.text = "Total Pick Up:  " + count.ToString();
    }

    void GeneratePrefab()
    {
        prefabPostionList = new List<Vector3>();
        prefabPostionList.Add(new Vector3(8, 0.5f, 8));
        prefabPostionList.Add(new Vector3(8, 0.5f, 4));
        prefabPostionList.Add(new Vector3(-8, 0.5f, -8));
        prefabPostionList.Add(new Vector3(-8, 0.5f, -1));
        prefabPostionList.Add(new Vector3(-8, 0.5f, -5));
        prefabPostionList.Add(new Vector3(1, 0.5f, -8));
        prefabPostionList.Add(new Vector3(1, 0.5f, 8));
        prefabPostionList.Add(new Vector3(7, 0.5f, -8));
        prefabPostionList.Add(new Vector3(-3, 0.5f, -3));
        prefabPostionList.Add(new Vector3(0, 0.5f, 2));

        for (int i = 0; i < prefabPostionList.Count; i++)
        {
            Instantiate(prefab, prefabPostionList[i], Quaternion.identity);

        }

    }
}

