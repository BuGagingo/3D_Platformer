using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Enemy : MonoBehaviour
{
    //Скорость движения врага
    public float speed;
 
    //Цель, к которой движется враг
    public Transform target;
    public Animator animator;
    public bool isReadyAttack = true;
 
    //Очки урона от атаки врагом игрока
    public int playerDamage = 2;
 
    public float needDistance = 10;
    void Start()
    {
        speed = UnityEngine.Random.Range(1.0f, 10.0f);
        target = GameObject.FindWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (PlayerInZone())
        {
            //Меняет каждый кадр позицию NPC на новую
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
            //Разворачивает каждый кадр NPC лицом к цели
            transform.LookAt(target.position);
        }
    }
    bool PlayerInZone()
    {
        Vector3 distance = target.position - transform.position;
        distance = new Vector3(Math.Abs(distance.x), Math.Abs(distance.y), Math.Abs(distance.z));
        float dis = distance.x + distance.y + distance.z;
        bool inZone = dis < needDistance;
        return inZone;
    }
    //При столкновении врага с игроком второму наносится урон
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && isReadyAttack)
        {
            animator.SetTrigger("Attack");
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.TakeDamage(playerDamage);
            isReadyAttack = false;
            StartCoroutine(ShortRes());
        }
    }
    IEnumerator ShortRes()
    {
        yield return new WaitForSeconds(1);
        isReadyAttack = true;
    }
}
