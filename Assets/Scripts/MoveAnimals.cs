using UnityEngine;

public class MoveAnimals : MonoBehaviour
{
    public int speed = 15; // Переменная для хранения скорости движения

    void Update()
    {
        // Перемещаем объект вперед по оси Z с учетом времени и скорости
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
