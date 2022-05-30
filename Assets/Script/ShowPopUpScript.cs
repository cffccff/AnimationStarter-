using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowPopUpScript : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
