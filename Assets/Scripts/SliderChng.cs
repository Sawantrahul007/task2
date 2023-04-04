using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChng : MonoBehaviour
{
    public Slider slider;
    private float time;
    public GameObject storypanel;
    public GameObject homepanel;
    public GameObject footer;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0;
        slider.maxValue = 8;
        time = 0;
        Debug.Log("Startctive");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;



    }
    private void LateUpdate()
    {
        
        slider.value = time;
        if (time > 8)
        {
            time = 0;
            storypanel.SetActive(false);
            homepanel.SetActive(true);
            footer.SetActive(true);
        }
    }
    public void SliderDisable()
    {
        
        time = 0;
        
    }
}
