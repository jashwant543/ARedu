using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching : MonoBehaviour
{
    // Start is called before the first frame update
    string cpe;
    //public GameObject LED;
    
    private Vector3 startpos;
    private Vector3 endpos;
    public float distance = 30f;
    public float lerptime = 3;
    private float currentlerp=0;
    private bool KeyHit = false;
    public GameObject LEDPanel;
    private GameObject prav = null;
    private GameObject curr;
    private Vector3 CP;
    public GameObject[] Compon;

    void Start()
    {
        
        //startpos = LED.transform.position;
        //endpos = LED.transform.position + Vector3.up * distance;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButton(0))
            {
            if(prav!=null)
            {
                prav.transform.position = new Vector3(CP.x, CP.y, CP.z);
            }
           
    Debug.Log("abc");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
               
                

                Debug.Log("abc");
                GameObject LED = hit.transform.gameObject;
                for(int i=0;i<Compon.Length;i++)
                {
                    if(LED.name==Compon[i].name)
                    {
                        Compon[i].SetActive(true);
                    }
                    else
                    {
                        Compon[i].SetActive(false);
                    }
                }

                //curr = LED;
                ////if (prav != null)

                ////{
                //    prav.transform.position = new Vector3(CP.x, CP.y, CP.z);
                //}
                prav = LED;
                CP = new Vector3(prav.transform.position.x, prav.transform.position.y, prav.transform.position.z);


                LED.transform.position = new Vector3(LED.transform.position.x, LED.transform.position.y + 0.3f, LED.transform.position.z);
                
                //if(LED.transform.position.x==curr.transform.position.x)
                //{
                Debug.Log("yes");
;                //}
                //Debug.Log(LED.transform.position.x);
                //Debug.Log(curr.transform.position.x);
                //prav = LED;
                //CP = new Vector3(prav.transform.position.x, prav.transform.position.y, prav.transform.position.z);


                //if (KeyHit == false)
                //{
                //    startpos = LED.transform.position;
                //    endpos = LED.transform.position + Vector3.up * distance;
                //    KeyHit = true;
                //}

              
                //    currentlerp += Time.deltaTime;
              
                //if(currentlerp>=lerptime)
                //    {
                //        currentlerp = lerptime;
                //    }
                       
                //float perc = currentlerp / lerptime;
                //LED.transform.position = Vector3.Lerp(startpos, endpos, perc);
                //LEDPanel.SetActive(true);
                
      
               
        
               //if(Input.GetMouseButton(0))
               // {
               //     startpos = endpos;
               //     endpos = LED.transform.position + Vector3.up * distance;
               //     KeyHit = false;
               //     currentlerp -= Time.deltaTime;

               //     if (currentlerp>=0f)
               //     {
               //         currentlerp = lerptime;
               //     }

               //     float perc1 = currentlerp / lerptime;
               //     LED.transform.position = Vector3.Lerp(startpos, endpos, perc1);
                    


               // }
                //        if (Input.touchCount>0 && Input.touches[0].phase==TouchPhase.Began)
                //{
                //    //Debug.Log("running");
                //    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                //    RaycastHit hit;
                //    if(Physics.Raycast(ray,out hit))
                //        {
                //    Debug.Log("abc");
                //        cpe = hit.transform.name;
                //        GameObject G1 = GameObject.Find(cpe);
                //        G1.SetActive(false);
                //    }
            }

        }
        
        
    }
}
