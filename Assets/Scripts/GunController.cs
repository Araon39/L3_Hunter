using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal; // ���������� ��� �������� ��������������� ����� ����
    private float vertical;   // ���������� ��� �������� ������������� ����� ����
    private float sensitivity = 2; // ���������������� ����������

    // Update ���������� ���� ��� �� ����
    void Update()
    {
        // �������� �������������� � ������������ �������� ���� � �������� �� ����������������
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical = Input.GetAxis("Mouse Y") * sensitivity;        

        // ������������ ������ ������ ��� Y (�����-������) � ����������� �� ��������������� �����
        transform.Rotate(0, horizontal, 0);

        // ������������ ������ ������ ��� X (�����-����) � ����������� �� ������������� �����
        transform.Rotate(0, 0, vertical);
    }
}
