using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variáveis públicas podem ser modificadas nos testes!!!
    public float moveSpeed = 5;
    public float HorInput;
    public Animator animator;
    //public CharacterController controller;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Em update, cada frame será utilizado 60x por segundo!
    void Update()
    // Queremos uma movimentação horizontal (dir. e esq.) = variar x!
    {
        HorInput = Input.GetAxisRaw("Horizontal"); //Vem de Assets, onde há todas as informações do player
        //estamos chamando esse asset para controlarmos o movimento do player

        transform.Translate(Vector2.right * HorInput * moveSpeed * Time.deltaTime); //Translate = escorregar, Vector2 = coordenadas x e y | outra forma de escrever = Vector2(1.0)
        // time.deltatime = uma forma matematica de contar o tempo

        transform.Translate(Vector2.left * HorInput * moveSpeed * Time.deltaTime);

        animator.SetFloat("speed", HorInput);
    }

}
