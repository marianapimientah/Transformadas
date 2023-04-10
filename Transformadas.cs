using UnityEngine;

//Realizado por: Mariana Alejandra Pimienta Hernandez - Ingeniería de Software 12a
public class Transformadas : MonoBehaviour
{
    public Vector3 point1;
    public Vector3 point2;
    public Vector3 point3;
    public Vector3 point4;
    public float moveSpeed;
    public float rotationSpeed;

    private Vector3 direction;
    private int currentPoint = 1;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        if (transform.position == point1)
        {
            direction = point2 - point1;
            currentPoint = 2;
        }
        else if (transform.position == point2)
        {
            direction = point3 - point2;
            currentPoint = 3;
        }
        else if (transform.position == point3)
        {
            direction = point4 - point3;
            currentPoint = 4;
        }
        else if (transform.position == point4)
        {
            direction = point1 - point4;
            currentPoint = 1;
        }

        transform.Translate(direction.normalized * Time.deltaTime * moveSpeed, Space.World);
    }
}