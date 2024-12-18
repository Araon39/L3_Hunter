using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal; // Переменная для хранения горизонтального ввода мыши
    private float vertical;   // Переменная для хранения вертикального ввода мыши
    private float sensitivity = 2; // Чувствительность управления

    // Update вызывается один раз за кадр
    void Update()
    {
        // Получаем горизонтальное и вертикальное движение мыши и умножаем на чувствительность
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical = Input.GetAxis("Mouse Y") * sensitivity;        

        // Поворачиваем объект вокруг оси Y (влево-вправо) в зависимости от горизонтального ввода
        transform.Rotate(0, horizontal, 0);

        // Поворачиваем объект вокруг оси X (вверх-вниз) в зависимости от вертикального ввода
        transform.Rotate(0, 0, vertical);
    }
}
