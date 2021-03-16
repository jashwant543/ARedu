using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scaleWithSlider : MonoBehaviour
{
    public Slider Scale;
    public float sc = 0.1f;
    public GameObject VolumeSurface;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(sc, sc, sc);
        VolumeSurface.GetComponent<Text>().text = "Volume = " + ((4 * sc * sc * sc * 3.14) / 3)+" Surface Area = "+ (4 * sc * sc * 3.14);
    }
    public void ChangeScale(float newSC)
    {
        sc = newSC;
    }
}
