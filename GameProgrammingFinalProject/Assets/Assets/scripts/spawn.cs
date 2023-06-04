using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject aiPrefab; // AI 프리팹을 할당할 변수
    public Transform spawnPoint; // AI를 생성할 위치
    public int maxSpawnCount = 20; // 생성할 AI의 총 수
    public float spawnInterval = 5f; // AI 생성 간격

    private int spawnCount = 0; // 생성된 AI의 수
    private float timer = 0f; // 경과 시간

    private void Update()
    {
        timer += Time.deltaTime;

        // 일정 간격으로 AI 생성
        if (timer >= spawnInterval && spawnCount < maxSpawnCount)
        {
            SpawnAI();
            timer = 0f;
        }
    }

    private void SpawnAI()
    {
        // AI 프리팹을 spawnPoint 위치에 생성
        Instantiate(aiPrefab, spawnPoint.position, spawnPoint.rotation);
        spawnCount++;

        // 생성된 AI의 수가 maxSpawnCount에 도달하면 스포너 비활성화
        if (spawnCount >= maxSpawnCount)
        {
            enabled = false;
        }
    }
}
