using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Vector2 entradasJogador;
    private int InputXHash = Animator.StringToHash("XInput");
    private int InputYHash = Animator.StringToHash("YInput");
    //public Transform unscaledTimeCube;
    private Rigidbody2D rb;
    private float velocidade = 4.5f;

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
        //unscaledTimeCube.Translate(Vector3.forward * Time.unscaledDeltaTime); //will always move //Will freeze if timescale is 0

        if (rb != null && Time.timeScale != 0)
        {
            entradasJogador = new Vector2(Input.GetAxisRaw("Horizontal"), 0); 
            animator.SetFloat(InputXHash, entradasJogador.x);
            transform.position += new Vector3(entradasJogador.x * velocidade * Time.deltaTime, 0, 0);
        }
    }
}
