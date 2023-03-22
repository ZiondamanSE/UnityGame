using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHelthSlider : MonoBehaviour
{
    private PlayerHelth healthManager;
    public Slider healthBar;
void Start()
{
    healthManager = FindObjectOfType<PlayerHelth>();
}
void Update()
{
    healthBar.maxValue = healthManager.maxHealth;
    healthBar.value = healthManager.currentHealth;
}
}
