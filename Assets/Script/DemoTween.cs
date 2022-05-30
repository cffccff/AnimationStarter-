using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class DemoTween : MonoBehaviour
{

    [SerializeField] GameObject panel;
    [SerializeField] Button buttonOpen, buttonClose;
    private Tween fadeTween;
    // Start is called before the first frame update
    void Start()
    {
      
        panel.transform.localScale = new Vector3(0, 0, 0);
        buttonOpen.onClick.AddListener(OpenClaimRewardPopUP);
        buttonClose.onClick.AddListener(CloseClaimRewardPopUP);
    }

    private void OpenClaimRewardPopUP()
    {
        panel.transform.DOScale(new Vector3(1f,1f,1f),1f);

    }
    private void CloseClaimRewardPopUP()
    {
        panel.transform.DOScale(new Vector3(0f, 0f, 0f), 1f);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
   
}