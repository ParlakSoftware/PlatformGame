﻿using UnityEngine;

public abstract class AHealth
{
    protected IAnimatorService _animatorService;
    protected HealthBar HealthBar;
    

    public AHealth(float health,IAnimatorService animatorService)
    {
        _animatorService = animatorService;
        Health = health;
    }
    public AHealth(float health,IAnimatorService animatorService,HealthBar healthBar){
        _animatorService = animatorService;
        Health = health;
        HealthBar = healthBar;
    } 
    
    public float _health;
    public float Health
    {
        get
        {
            if (_health > 0 && _health <= 100)
                return _health;
            else if (_health > 100)
                return 100;
            else
                return 0;
        }
        set
        {
            _health = value;
        }
    }

    public float GetHealth()
    {
        return Health;
    }
    public void SetHealth(float health)
    {
        Health = health;
    }
    public void CanAzalt(float health)
    {
        Health -= health;
        if (GetHealth() <= 0) Dead();
        else HasarAl();
    }
    public void CanArttir(float health)
    {
        Health += health;
        Debug.Log("Can Ekledik, Yeni Can : " + GetHealth());
    }
    public abstract void HasarAl();
    public abstract void Dead();
}