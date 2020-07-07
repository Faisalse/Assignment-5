using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float speed=10;
    Rigidbody rb;
    public GameObject prefab;
    List<Vector3> prefabPostionList;
    public TextMesh text1;
// Faisal
    public TextMesh text2;
    public TextMesh text3;
    public TextMesh text4;
    public TextMesh text5;
    public TextMesh text6;
    public TextMesh text7;
    public TextMesh text8;
    public TextMesh text9;
    public TextMesh text10;
    public Text textcomp;
    string[] listt;
    int count;
  

    void Start()
    {           
        
        rb = GetComponent<Rigidbody>();
        GeneratePrefab();
        count = 0;





    }
    private void FixedUpdate()
    {   
        float horizental = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector3 = new Vector3(horizental, 0.0f, vertical);
        rb.AddForce(vector3 * speed);
        if (count ==10)
        {
            textcomp.text = "You have collect all random strings";
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pick Up"))
        {
            if (Vector3.Distance(other.gameObject.transform.position, text1.transform.position) == 0)
            {
                count += 1;
                text1.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text2.transform.position) == 0)
            {
                count += 1;
                text2.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text3.transform.position) == 0)
            {
                count += 1;
                text3.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text4.transform.position) == 0)
            {
                count += 1;
                text4.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text5.transform.position) == 0)
            {
                count += 1;
                text5.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text6.transform.position) == 0)
            {
                count += 1;
                text6.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text7.transform.position) == 0)
            {
                count += 1;
                text7.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text8.transform.position) == 0)
            {
                count += 1;
                text8.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text9.transform.position) == 0)
            {
                count += 1;
                text9.text = "";
                other.gameObject.SetActive(false);
            }
            else if (Vector3.Distance(other.gameObject.transform.position, text10.transform.position) == 0)
            {
                count += 1;
                text10.text = "";
                other.gameObject.SetActive(false);
            }
            else
            {
                
            }
            
        }
       

    }
    void setTextCount()
    {
        //countText.text = "Total Pick Up:  " + count.ToString();
    }

    void GeneratePrefab()
    {
        prefabPostionList = new List<Vector3>();
        // 1
        prefabPostionList.Add(new Vector3(8, 0.5f, 8));
        // 2
        prefabPostionList.Add(new Vector3(12, 0.5f, 2));
        // 3
        prefabPostionList.Add(new Vector3(-12, 0.5f, -8));
        // 4
        prefabPostionList.Add(new Vector3(-12, 0.5f, 3));
        // 5
        prefabPostionList.Add(new Vector3(-12, 0.5f, -15));
        // 6
        prefabPostionList.Add(new Vector3(1, 0.5f, -8));
        // 7
        prefabPostionList.Add(new Vector3(1, 0.5f, 8));
        // 8
        prefabPostionList.Add(new Vector3(12, 0.5f, -14));
        // 9
        prefabPostionList.Add(new Vector3(-3, 0.5f, -6));
        // 10
        prefabPostionList.Add(new Vector3(0, 0.5f, 2));

        for (int i = 0; i < prefabPostionList.Count; i++)
        {
            Instantiate(prefab, prefabPostionList[i], Quaternion.identity);
        }
        listt = stringlist();
        text1.text = ""+listt[0];
        text2.text = "" + listt[1];
        text3.text = "" + listt[2];
        text4.text = "" + listt[3];
        text5.text = "" + listt[4];
        text6.text = "" + listt[5];
        text7.text = "" + listt[6];
        text8.text = "" + listt[7];
        text9.text = "" + listt[8];
        text10.text = "" + listt[9];

    }

    public static string GenerateString(int length, System.Random random)
    {
        string characters = "XS1";
        StringBuilder result = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            result.Append(characters[random.Next(characters.Length)]);
        }
        return result.ToString();
    }

    static string[] stringlist()
    {
        string[] b = new string[10];
        System.Random random = new System.Random();
        for (int i = 0; i < 10; i++ )
        {
            b[i] = GenerateString(10, random);
        }
        return b;
    }
}

