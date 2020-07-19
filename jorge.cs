using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jorge : MonoBehaviour {
    public float movementSpeed = 1f;   //velocidade do player
    public Vector2 movement;           //trasnforma Vector em variavel (vector 2 controla os eixos (x, y)
    public Rigidbody2D rigidbody;      //transforma o Rigidbody em variavel
    public Animator animator;

    // primeiro frame
    void Start() {          //quando iniciar o jogo
        rigidbody = this.GetComponent<Rigidbody2D>();           //declara valor a variavel Rigidbody
        animator = this.GetComponent<Animator>();
        animator.Play("jorge_dir");
    }
    private void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");            //usa as teclas padroes para movimentar horizontalmente 
        movement.y = Input.GetAxisRaw("Vertical");              //usa as teclas padroes para movimentar verticalmente          
    }

    // call de comandos a cada frame
    void FixedUpdate() {
        rigidbody.MovePosition(rigidbody.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
