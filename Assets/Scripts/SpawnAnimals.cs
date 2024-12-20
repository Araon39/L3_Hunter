using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animals;    // Массив префабов животных, которые будут появляться

    private int index;              // Индекс для выбора животного из массива
    private Vector3 position;       // Позиция для появления животного

    private void Start()
    {
        // Запускаем метод Spawn через 2 секунды и повторяем его каждые 3 секунды
        InvokeRepeating("Spawn", 2, 3);
    }

    void Spawn()
    {
        // Генерируем случайную позицию в заданных пределах
        position = new Vector3(Random.Range(-15, 15), -4.5f, Random.Range(11, 25));

        // Выбираем случайное животное из массива
        index = Random.Range(0, animals.Length);

        // Создаем экземпляр выбранного животного в случайной позиции с его стандартной ориентацией
        Instantiate(animals[index], position, animals[index].transform.rotation);
    }
}
