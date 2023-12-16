using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
 
        Inventory player = other.GetComponent<Inventory>();
 
        //Количество монеток обновляется
        player.CollectCoins();
 
        //Монетка, которую собрали, уничтожается
        Destroy(gameObject);
    }
 
}
