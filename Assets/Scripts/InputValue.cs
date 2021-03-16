using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputValue : MonoBehaviour
{
    public InputField inputFieldX;
    public GameObject G11;
    public InputField inputFieldY;
    public InputField inputFieldZ;
    public InputField inputFieldRadius;
    private float[] v;
    Vector3 newScale;
    Vector3 tempPos;
    float Radius;
    
    public GameObject VolumeSurface;
    float c1;
    //public GameObject VolumeSurface;
    public GameObject Texts;
    int Volumes = 0;
   
    private void Start()
    {
        v = new float[4];
        //tempPos = G11.transform.position;
        //Debug.Log(G11.transform.localPosition.x);


    }
    

    private void OnEnable()
    {
        // whenever these inputfields are edited, call these functions
        inputFieldX.onEndEdit.AddListener(OnXEdited);
        inputFieldY.onEndEdit.AddListener(OnYEdited);
        inputFieldZ.onEndEdit.AddListener(OnZEdited);
        inputFieldRadius.onEndEdit.AddListener(OnRadiusEdited);
    }

    public void OnDisable()
    {
        inputFieldX.onEndEdit.RemoveListener(OnXEdited);
        inputFieldY.onEndEdit.RemoveListener(OnYEdited);
        inputFieldZ.onEndEdit.RemoveListener(OnZEdited);
        inputFieldRadius.onEndEdit.RemoveListener(OnRadiusEdited);

    }

    public void OnXEdited(string newText)
    {
     
       // Vector3 newScale = G11.transform.localScale;
        newScale.x = float.Parse(newText);
        v[0] = newScale.x;
        ShowValues(v);
        //G11.transform.localScale = newScale;
        //Volume.text = newScale.x.ToString();
        
    }

    public void OnYEdited(string newText)
    {
        //Vector3 newScale = G11.transform.localScale;
        newScale.y = float.Parse(newText);
       
        v[1] = newScale.y;
        ShowValues(v);

      // G11.transform.localScale = newScale;
    }

    public void OnZEdited(string newText)
    {
        //Vector3 newScale = G11.transform.localScale;
        newScale.z = float.Parse(newText);
        v[2] = newScale.z;
        
    }
    public void OnRadiusEdited(string newText)
    {
        //Vector3 newScale = G11.transform.localScale;
         Radius = float.Parse(newText);
        v[3] = Radius;
        Debug.Log(Radius);
        ShowValues(v);

    }
    public void ShowValues(float [] a)
    {
        
        float temp = 0;

        if (a[0] != 0 && a[1] != 0 && a[2] != 0&&a[3]!=0)
        {
            temp = (a[0] * a[0]) + (a[1] * a[1])+ (a[2]*a[2]);
            Texts.GetComponent<Text>().text = "x^2 + Y^2 + Z^2 + " + temp + " + " + (-1) * 2 * a[0] + "X " + (-1) * 2 * a[1] + "Y " + (-1) * 2 * a[2] + "Z = " + a[3] * a[3];
            Debug.Log(a[2]);
           // double change = a[0] * 0.1;
            //tempPos.x += change;

            G11.SetActive(true);
           
              

            G11.transform.localPosition = new Vector3(a[0]+0.1f, a[1]+0.1f,a[2]+0.1f);
            G11.transform.localScale = new Vector3(a[3], a[3], a[3]);
        }
    }
    private void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
            {
            Ray obj = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit click;
            if (Physics.Raycast(obj, out click))
            {
                GameObject tempri = click.transform.gameObject;
                if(tempri.name==G11.name)
                {
                    VolumeSurface.SetActive(true);
                }
                if(Input.GetMouseButton(2))
                {
                    VolumeSurface.SetActive(false);
                }
            }
        }
    }
    
    //public void Reset()
    //{ 
    //    v[0] = 0;
    //    v[1] = 0;
    //    v[2] = 0;
    //    v[3] = 0;
    //    ShowValues(v);
    //}
}
