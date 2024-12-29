using UnityEngine;

public class Inimigo3Movimento : MonoBehaviour
{
    public float descentSpeed = 3f; // Velocidade de descida
    public float rotationSpeed = 50f; // Velocidade do movimento circular
    public Vector2 centerPosition = new Vector2(0f, 2f); // Posição central para o movimento circular
    public float radius = 2f; // Raio do movimento circular

    private bool isRotating = false; // Indica se o objeto está no movimento circular
    private float angle = 0f; // Ângulo atual do movimento circular

    private void Update()
    {
        if (!isRotating)
        {
            // Movimento descendente até a posição central
            transform.position = Vector2.MoveTowards(transform.position, centerPosition, descentSpeed * Time.deltaTime);

            // Verifica se chegou à posição central
            if (Vector2.Distance(transform.position, centerPosition) < 0.1f)
            {
                isRotating = true; // Inicia o movimento circular
            }
        }
        else
        {
            // Movimento circular
            angle += rotationSpeed * Time.deltaTime; // Atualiza o ângulo
            float radianAngle = Mathf.Deg2Rad * angle; // Converte o ângulo para radianos

            // Calcula a posição do objeto com base no ângulo
            float x = centerPosition.x + Mathf.Cos(radianAngle) * radius;
            float y = centerPosition.y + Mathf.Sin(radianAngle) * radius;
            transform.position = new Vector2(x, y);

            // Mantém o ângulo entre 0 e 360 graus
            if (angle >= 360f)
            {
                angle -= 360f;
            }
        }
    }
}
