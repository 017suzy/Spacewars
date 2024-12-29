using UnityEngine;

public class Inimigo3movimento : MonoBehaviour
{
    public float speed = 2f; // Velocidade do inimigo
    public float changeDirectionInterval = 3f; // Tempo para mudar de direção
    public Vector2 verticalLimits = new Vector2(0f, 4f); // Limites verticais
    public Vector2 horizontalLimits = new Vector2(-9f, 9f); // Limites horizontais

    private Vector2 direction; // Direção atual do movimento
    private float directionChangeTimer; // Temporizador para mudança de direção

    private void Start()
    {
        // Define uma direção inicial aleatória
        ChangeDirection();
    }

    private void Update()
    {
        // Movimenta o inimigo na direção atual
        transform.Translate(direction * speed * Time.deltaTime);

        // Verifica se atingiu os limites verticais
        if (transform.position.y > verticalLimits.y || transform.position.y < verticalLimits.x)
        {
            direction.y *= -1; // Inverte a direção vertical
        }

        // Verifica se atingiu os limites horizontais
        if (transform.position.x > horizontalLimits.y || transform.position.x < horizontalLimits.x)
        {
            direction.x *= -1; // Inverte a direção horizontal
        }

        // Temporizador para mudar a direção
        directionChangeTimer += Time.deltaTime;
        if (directionChangeTimer >= changeDirectionInterval)
        {
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        // Gera uma nova direção aleatória
        direction = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized; // Normaliza para manter a velocidade constante

        // Reinicia o temporizador
        directionChangeTimer = 0f;
    }
}
