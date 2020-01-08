﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Sprite damagedSprite;
    public int hp = 4;
    public AudioClip chopSound1;
    public AudioClip chopSound2;

    SpriteRenderer spriteRenderer;

    void Awake()
    {
        //damagedSprite = GetComponent<Sprite>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void DamageWall(int loss)
    {
        SoundManager.instance.RandomiseFx(chopSound1, chopSound2);
        spriteRenderer.sprite = damagedSprite;
        hp -= loss;
        if (hp <= 0)
            gameObject.SetActive(false);
    }
}
