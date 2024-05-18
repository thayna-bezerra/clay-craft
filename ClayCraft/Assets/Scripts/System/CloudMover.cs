using UnityEngine;

public class CloudMover : MonoBehaviour
{
    // Velocidade de movimento das nuvens
    public float speed = 0.1f;

    // Dist�ncia antes das nuvens resetarem a posi��o
    public float resetPositionX = -20f;
    public float startPositionX = 20f;

    void Update()
    {
        // Move as nuvens para a esquerda ao longo do eixo X
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Verifica se a posi��o da nuvem passou do limite e a reseta para a posi��o inicial
        if (transform.position.x < resetPositionX)
        {
            Vector3 newPosition = transform.position;
            newPosition.x = startPositionX;
            transform.position = newPosition;
        }
    }
}
