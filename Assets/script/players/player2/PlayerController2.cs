using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Animator animator;
    private Vector2 entradasJogador;
    private int InputXHash = Animator.StringToHash("XInput");
    private Rigidbody2D rb;
    private float velocidade = 5f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component is missing on " + gameObject.name);
        }
    }

    void Update()
    {
        if (rb != null && Time.timeScale != 0)
        {
            entradasJogador = new Vector2(Input.GetAxisRaw("Horizontal"), 0);  // Player 2 usa "Horizontal2" no Input
            animator.SetFloat(InputXHash, entradasJogador.x);
            transform.position += new Vector3(entradasJogador.x * velocidade * Time.deltaTime, 0, 0);
        }
    }
}
