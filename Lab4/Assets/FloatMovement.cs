using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatMovement : MonoBehaviour
{
    private CapsuleCollider capsule;
    private float old_pos;
    public int increase_flag;

    public int can_float;
    private Animator anim;
    public float inc_amount = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        capsule = GetComponent<CapsuleCollider>();
        anim = GetComponent<Animator>();
        old_pos = transform.position.x;
        increase_flag = 1;
        can_float = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.anim.GetCurrentAnimatorStateInfo(0).IsName("Player_Duck")){
            if(old_pos < transform.position.x){
                if(increase_flag==1){
                    capsule.height += inc_amount;
                    if(capsule.height >= 2.0){
                        increase_flag = 0;
                    }
                }else{
                    capsule.height -= inc_amount;
                    if(capsule.height <= 0.2f){
                        increase_flag = 1;
                    }
                }
            }

            if(old_pos > transform.position.x){
                if(increase_flag==1){
                    capsule.height += inc_amount;
                    if(capsule.height >= 2.0){
                        increase_flag = 0;
                    }
                }else{
                    capsule.height -= inc_amount;
                    if(capsule.height <= 0.5f){
                        increase_flag = 1;
                    }
                }
            }

            old_pos = transform.position.x;
        }
    }
}
