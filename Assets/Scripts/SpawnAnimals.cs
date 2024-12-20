using UnityEngine;

//Ётот код создает животных в случайных позици€х через определенные промежутки времени,
//увеличива€ количество создаваемых животных с каждым вызовом метода Spawn.

public class SpawnAnimals : MonoBehaviour
{
    
    public GameObject[] animals;                // ћассив префабов животных, которые будут по€вл€тьс€     
    private int index;                          // »ндекс дл€ выбора животного из массива    
    private Vector3 position;                   // ѕозици€ дл€ по€влени€ животного    
    [SerializeField] private int spawnCount;    //  оличество животных, которые будут по€вл€тьс€

    private void Start()
    {
        // «апускаем метод Spawn через 2 секунды и повтор€ем его каждые 3 секунды
        InvokeRepeating("Spawn", 2, 3);
    }

    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            // √енерируем случайную позицию в заданных пределах
            position = new Vector3(Random.Range(-15, 15), -4.5f, Random.Range(11, 25));

            // ¬ыбираем случайное животное из массива
            index = Random.Range(0, animals.Length);

            // —оздаем экземпл€р выбранного животного в случайной позиции с его стандартной ориентацией
            Instantiate(animals[index], position, animals[index].transform.rotation);
        }
       
        spawnCount++; // ”величиваем количество животных, которые будут по€вл€тьс€, на 1
    }
}

