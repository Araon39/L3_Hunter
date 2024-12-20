using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animals;    // ������ �������� ��������, ������� ����� ����������

    private int index;              // ������ ��� ������ ��������� �� �������
    private Vector3 position;       // ������� ��� ��������� ���������

    private void Start()
    {
        // ��������� ����� Spawn ����� 2 ������� � ��������� ��� ������ 3 �������
        InvokeRepeating("Spawn", 2, 3);
    }

    void Spawn()
    {
        // ���������� ��������� ������� � �������� ��������
        position = new Vector3(Random.Range(-15, 15), -4.5f, Random.Range(11, 25));

        // �������� ��������� �������� �� �������
        index = Random.Range(0, animals.Length);

        // ������� ��������� ���������� ��������� � ��������� ������� � ��� ����������� �����������
        Instantiate(animals[index], position, animals[index].transform.rotation);
    }
}
