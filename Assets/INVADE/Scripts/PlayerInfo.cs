﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance;

    public Image healthBarSlider;

    public float curHealthPoint;
    public float maxHealthPoint;
    // Start is called before the first frame update

    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        maxHealthPoint = 150;
        curHealthPoint = 150;  // 시작 HP
    }

    public void GetDamage(float damage)
    {
        curHealthPoint -= damage;

        if (curHealthPoint <= 0)
        {
            curHealthPoint = 0;
            //GameManager.instance.GameOver();
        }
        SetHealthBarUI();
    }
    public void SetHealthBarUI()
    {
        healthBarSlider.fillAmount = curHealthPoint / maxHealthPoint;
    }
}
