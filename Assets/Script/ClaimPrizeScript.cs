using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ClaimPrizeScript : MonoBehaviour
{
   [SerializeField] Button button;
    [SerializeField] Slider coin_slider, gem_slider;
    [SerializeField] int animationTime = 2;
    bool isClicked = false;
    private Tween tweenShaking;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
      
    }

    private void TaskOnClick()
    {
       
        if(isClicked == false)
        {
            float coinValueRandom = UnityEngine.Random.Range(0.1f, 0.9f);
            float gemValueRandom = UnityEngine.Random.Range(0.1f, 0.9f);
            Debug.Log("random value of coin is:" + coinValueRandom);
            Debug.Log("random value of coin is:" + gemValueRandom);
            DOTween.To(() => coin_slider.value, x => coin_slider.value = x, coinValueRandom, animationTime);
            DOTween.To(() => gem_slider.value, x => gem_slider.value = x, gemValueRandom, animationTime);
            isClicked = true;
        }
        else
        {
            button.GetComponentInChildren<Text>().text = " You already claim the Reward";
            tweenShaking = button.transform.DOShakeRotation(0.5f, 40, 4, 20, true);
            
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
