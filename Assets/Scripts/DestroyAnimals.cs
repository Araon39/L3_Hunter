using UnityEngine;

public class DestroyAnimals : MonoBehaviour
{
    // ����� ���������� ��� ����� ������� ������� � �������
    private void OnTriggerEnter(Collider other)
    {
        // ���������, ����� �� ������ ��� "Animal"
        if (other.gameObject.CompareTag("Animal"))
        {
            // ���������� ������, ������� ����� � �������
            Destroy(other.gameObject);

            // ���������� ������� ������ (���, � �������� ���������� ���� ������)
            Destroy(gameObject);
        }
    }
}
