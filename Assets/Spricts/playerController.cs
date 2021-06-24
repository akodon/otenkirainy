using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour
{
    //値はインスペクターから変更可能
    [SerializeField]private float Speed = 10;
    private Rigidbody2D rb2d;

    //ジャンプのぱわー
    public float Jump = 8;

    public bool isGround { get; set; }

    Animator _animator;

    private void Start()
    {
        //ゲームプレイ中、頻繁に呼び出されるコンポーネントはStart内でキャッシュしておく
        //GetComponentすると不可が高くなるため
        rb2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
 
        isGround = false;
        
    }

    public void FixedUpdate()
    {
        //左右方向に入力を受け取る
        var h = Input.GetAxis("Horizontal") ;
        rb2d.AddForce(Vector2.right * h * Speed);
        //スペースでジャンプする
      

        if (h >= 0.1)
        {

            _animator.SetBool("Runbool",true);
        }
      else if (h <= -0.1)
        {
            _animator.SetBool("RunRun", true);
        }


        else if(h==0.0)
        {
            _animator.SetBool("Runbool", false);
            _animator.SetBool("RunRun", false);
        }

 

        if (Input.GetKeyDown(KeyCode.Space) && isGround==true)
        {
            isGround = false;
            
            rb2d.velocity = Vector2.up * Jump;


  



        }
      if (isGround == false)
        {
            _animator.SetBool("Jumpbool", true);
        }

        else if (isGround == true)
        {
            _animator.SetBool("Jumpbool", false);
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rain"))
        {
            _animator.SetTrigger("Damagetrigger");
        }
    }





}

