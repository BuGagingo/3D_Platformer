using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    //Здоровье игрока
    public int health = 10;
    public int maxHealth = 10;
    public AudioSource audioSource;
    
    //Звуковой файл, содержащий звук урона
    public AudioClip damageSound;
    
    public void TakeDamage(int damage)
    {
        //Обновление очков здоровья игрока с учётом урона
        health -= damage;
 
        if(health > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
