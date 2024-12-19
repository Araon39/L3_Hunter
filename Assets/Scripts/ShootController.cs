using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject bullet; // Ссылка на префаб пули, который будет создан при выстреле

    // Update вызывается один раз за кадр
    void Update()
    {
        // Если левая кнопка мыши была нажата
        if (Input.GetMouseButtonDown(0))
        {
            // Создаем экземпляр объекта пули
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
