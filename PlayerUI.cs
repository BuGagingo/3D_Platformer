using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class PlayerUI : MonoBehaviour
{
	public Inventory inventory;
    public PlayerStats playerStats;
	public TextMeshProUGUI coinsCounterText;
	public Slider healthSlider;

	void Update()
	{
		// Обновляем значение здоровья игрока
		healthSlider.maxValue = playerStats.maxHealth;
		healthSlider.value = playerStats.health;
		
		// Обновляем текст с кол-вом монеток
		coinsCounterText.text = inventory.coins.ToString("0000");
	}
}
