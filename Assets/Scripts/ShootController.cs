using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject bullet; // ������ �� ������ ����, ������� ����� ������ ��� ��������

    // Update ���������� ���� ��� �� ����
    void Update()
    {
        // ���� ����� ������ ���� ���� ������
        if (Input.GetMouseButtonDown(0))
        {
            // ������� ��������� ������� ����
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
