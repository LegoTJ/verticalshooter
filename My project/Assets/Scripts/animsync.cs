using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animsync : MonoBehaviour
{
    public GameObject Vehicle;
    public Animator animator;
    public Animator enemy;


    // Start is called before the first frame update
    void Start()
    {


        if (!Vehicle.activeSelf)
        {
            animator.speed = 0f;
            enemy.speed = 0f;
            //Debug.Log("Vehicle is initially inactive, pausing both animations.");
        }
        else
        {
            animator.speed = 1f;
            enemy.speed = 1f;
            float enemyTime = enemy.GetCurrentAnimatorStateInfo(0).normalizedTime;
            animator.Play(enemy.GetCurrentAnimatorStateInfo(0).fullPathHash, 0, enemyTime);
            //enemy.Play(enemy.GetCurrentAnimatorStateInfo(0).fullPathHash, 0, 0f);
            //Debug.Log("Vehicle is initially active, starting both animations from beginning.");

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!Vehicle.activeSelf)
        {
            animator.speed = 0f;
            enemy.speed = 0f;
            //Debug.Log("Vehicle is initially inactive, pausing both animations.");
        }
        else
        {
            animator.speed = 1f;
            enemy.speed = 1f;
            float enemyTime = enemy.GetCurrentAnimatorStateInfo(0).normalizedTime;
            animator.Play(enemy.GetCurrentAnimatorStateInfo(0).fullPathHash, 0, enemyTime);
            //enemy.Play(enemy.GetCurrentAnimatorStateInfo(0).fullPathHash, 0, 0f);
            //Debug.Log("Vehicle is initially active, starting both animations from beginning.");

        }
    }
}
