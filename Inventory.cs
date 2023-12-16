using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int coins;
    public AudioSource audioSource;
    
    //Звуковой файл, содержащий звук урона
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CollectCoins()
    {
        coins++;
        audioSource.clip = coinSound;
        audioSource.Play();
        Invoke("StopSound", 1);
        print("Собранные монетки: " + coins);
    }
    void StopSound()
    {
        audioSource.Stop();
    }
}
