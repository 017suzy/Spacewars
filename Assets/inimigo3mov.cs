using UnityEngine;

public class Enemy3Movement : MonoBehaviour
{
    public float speed = 5f; // Velocidade do movimento reto para baixo
    public float rectangleSpeed = 3f; // Velocidade do movimento no retângulo
    public float rectangleWidth = 6f; // Comprimento no eixo X (lado maior)
    public float rectangleHeight = 2f; // Comprimento no eixo Y (lado menor)

    private int stopY; // Posição Y onde o inimigo para ao descer
    private bool isEnteringScene = true; // Indica se está descendo para entrar na cena
    private bool isRectangleMovement = false; // Indica se está no movimento retangular

    private Vector3 startPosition; // Posição inicial do movimento retangular
    private Vector3 targetPosition; // Próxima posição no movimento retangular
    private int rectangleStep = 0; // Etapa atual no movimento retangular

    void Start()
    {
        // Determina aleatoriamente o valor de Y de parada (4, 3 ou 2)
        stopY = Random.Range(0, 3) switch
        {
            0 => 4,
            1 => 3,
            _ => 2
        };
    }

    void Update()
    {
        if (isEnteringScene)
        {
            MoveStraightDown();
        }
        else if (!isRectangleMovement)
        {
            PerformInitialMovements();
        }
        else
        {
            PerformRectangleMovement();
        }
    }

    private void MoveStraightDown()
    {
        // Movimento reto para baixo
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Verifica se atingiu o Y de parada
        if (transform.position.y <= stopY)
        {
            isEnteringScene = false; // Parar o movimento reto
        }
    }

    private void PerformInitialMovements()
    {
        // Primeiro movimento: horizontal
        if (targetPosition == Vector3.zero)
        {
            targetPosition = transform.position.x < 0
                ? transform.position + new Vector3(rectangleWidth / 2, 0, 0) // Para direita
                : transform.position - new Vector3(rectangleWidth / 2, 0, 0); // Para esquerda
        }

        // Mover em direção ao alvo
        MoveToTarget();

        // Após concluir o primeiro movimento
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Segundo movimento: vertical
            targetPosition = stopY == 2
                ? transform.position + new Vector3(0, rectangleHeight / 2, 0) // Para cima
                : transform.position - new Vector3(0, rectangleHeight / 2, 0); // Para baixo

            isRectangleMovement = true; // Transição para o movimento retangular
            startPosition = transform.position; // Define o ponto inicial do retângulo
            SetNextRectangleTarget();
        }
    }

    private void PerformRectangleMovement()
    {
        MoveToTarget();

        // Verifica se alcançou o alvo
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            rectangleStep = (rectangleStep + 1) % 4; // Avança para o próximo passo (0 a 3)
            SetNextRectangleTarget(); // Define o próximo alvo
        }
    }

    private void MoveToTarget()
    {
        // Move o inimigo em direção ao alvo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, rectangleSpeed * Time.deltaTime);
    }

    private void SetNextRectangleTarget()
    {
        // Define a próxima posição no movimento retangular com base na etapa atual
        switch (rectangleStep)
        {
            case 0: // Movimento para a direita
                targetPosition = startPosition + new Vector3(rectangleWidth, 0, 0);
                break;
            case 1: // Movimento para baixo
                targetPosition = startPosition + new Vector3(rectangleWidth, -rectangleHeight, 0);
                break;
            case 2: // Movimento para a esquerda
                targetPosition = startPosition + new Vector3(0, -rectangleHeight, 0);
                break;
            case 3: // Movimento para cima (volta ao início)
                targetPosition = startPosition;
                break;
        }
    }
}
