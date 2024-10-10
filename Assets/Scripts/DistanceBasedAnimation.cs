using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBasedAnimation : MonoBehaviour
{
    private Transform object1; 
    public Transform object2;  
    public float triggerDistance = 0.60f;
    public Animator myAnimator; 
    private bool isAttacking = false;

    void Start()
    {
        object1 = GetComponent<Transform>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (myAnimator!=null)
        {
            float distance = Vector3.Distance(object1.position, object2.position);
            if (distance <= triggerDistance && !isAttacking)
            {
                myAnimator.SetTrigger("Attack");
                isAttacking = true;
            }
            else if (distance > triggerDistance && isAttacking)
            {
                myAnimator.SetTrigger("Idle");
                isAttacking = false;
            }
        }
        
    }
}

