using UnityEngine;

public class CubeMover : MonoBehaviour
{
    // 이동 속도 변수
    public float speed = 5f;

    void Start()
    {
        Debug.Log("게임 시작!");
    }
    
    void Update()
    {
        Debug.Log("매 프레임 실행 중...");

        // 1️⃣ 입력 받기 (Arrow Keys 또는 WASD)
        float moveX = 0f;
        float moveZ = 0f;

        // or
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveZ = 1f;
            Debug.Log("Input: W");
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveZ = -1f;
            Debug.Log("Input: S");
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveX = 1f;
            Debug.Log("Input: D");
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -1f;
            Debug.Log("Input: A");
        }

        // 2️⃣ 이동 벡터 만들기
        Vector3 move = new Vector3(moveX, 0, moveZ);

        // 3️⃣ 속도 적용
        transform.Translate(move * speed * Time.deltaTime);

        Debug.Log($"현재 위치: {transform.position}");
    }
}
