using UnityEngine;

public class MoveAnimals : MonoBehaviour
{
    private int speed = 15; // ���������� ��� �������� �������� ��������

    void Update()
    {
        // ���������� ������ ������ �� ��� Z � ������ ������� � ��������
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
