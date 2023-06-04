using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject aiPrefab; // AI �������� �Ҵ��� ����
    public Transform spawnPoint; // AI�� ������ ��ġ
    public int maxSpawnCount = 20; // ������ AI�� �� ��
    public float spawnInterval = 5f; // AI ���� ����

    private int spawnCount = 0; // ������ AI�� ��
    private float timer = 0f; // ��� �ð�

    private void Update()
    {
        timer += Time.deltaTime;

        // ���� �������� AI ����
        if (timer >= spawnInterval && spawnCount < maxSpawnCount)
        {
            SpawnAI();
            timer = 0f;
        }
    }

    private void SpawnAI()
    {
        // AI �������� spawnPoint ��ġ�� ����
        Instantiate(aiPrefab, spawnPoint.position, spawnPoint.rotation);
        spawnCount++;

        // ������ AI�� ���� maxSpawnCount�� �����ϸ� ������ ��Ȱ��ȭ
        if (spawnCount >= maxSpawnCount)
        {
            enabled = false;
        }
    }
}
