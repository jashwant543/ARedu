using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{
    public string name;
    public string k;
    public GameObject TText;
    public GameObject IF;
    public GameObject circle;
   int h;
   
    // Start is called before the first frame update

    public void ShowName()
    {
        //h = int.Parse(name);
        //h = h * h;
         //name = h.ToString();
        name = IF.GetComponent <Text>().text;
        TText.GetComponent<Text>().text = "X^2 + " + name +" " + k ;
        circle.SetActive(true);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
