using UnityEngine;

public class DestroyAnimals : MonoBehaviour
{
    // Метод вызывается при входе другого объекта в триггер
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, имеет ли объект тег "Animal"
        if (other.gameObject.CompareTag("Animal"))
        {
            // Уничтожаем объект, который вошел в триггер
            Destroy(other.gameObject);

            // Уничтожаем текущий объект (тот, к которому прикреплен этот скрипт)
            Destroy(gameObject);
        }
    }
}
