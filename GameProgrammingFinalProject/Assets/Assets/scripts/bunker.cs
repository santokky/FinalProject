using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunker : MonoBehaviour
{
    public int maxHealth = 100; // Finish ������Ʈ�� �ִ� ü��
    public int damageAmount = 20; // �� �浹���� �پ�� ü�� ��

    private int currentHealth; // ���� ü��

    private void Start()
    {
        currentHealth = maxHealth; // ���� �� ���� ü���� �ִ� ü������ �ʱ�ȭ
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Enemy ������Ʈ ����

            currentHealth -= damageAmount; // Finish ������Ʈ�� ü�� ����

            // ü���� 0 ���Ϸ� �������� ó���� ������ ���⿡ �߰�
            if (currentHealth <= 0)
            {
                // ü���� 0 ���Ϸ� ������ ����� ���� ó��
                Debug.Log("Finish destroyed!");
                // ���⿡�� Finish ������Ʈ�� �����ϰų� �ٸ� ������ ������ �� �ֽ��ϴ�.
            }
        }
    }
}
