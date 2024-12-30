using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Vector2 entradasJogador;
    private int InputXHash = Animator.StringToHash("Xinput");
    private int InputYHash = Animator.StringToHash("Yinput");

    private Rigidbody2D rb;
    private float velocidade = 2.0f;

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
        if (rb != null)
        {
            entradasJogador = new Vector2(Input.GetAxisRaw("Horizontal"), 0); 
            animator.SetFloat(InputXHash, entradasJogador.x);
            transform.position += new Vector3(entradasJogador.x * velocidade * Time.deltaTime, 0, 0);
        }
    }
}
