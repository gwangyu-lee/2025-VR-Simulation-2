using UnityEngine;

public class CubeFall : MonoBehaviour
{
    private Rigidbody rb;       // Rigidbody 컴포넌트를 저장할 변수
    private bool hasFallen = false; // 한 번만 떨어지게 하기 위한 플래그

    void Start()
    {
        // Rigidbody 컴포넌트 가져오기
        rb = GetComponent<Rigidbody>();

        // 시작할 때 중력 비활성화 → 공중에 떠 있게
        rb.useGravity = false;

        Debug.Log("게임 시작! 큐브가 공중에 떠 있습니다.");
    }

    void Update()
    {
        // 마우스 왼쪽 버튼 클릭 시
        // and 둘다 참
        if (Input.GetMouseButtonDown(0) && !hasFallen)
        {
            rb.useGravity = true;   // 중력 활성화
            hasFallen = true;       // 다시 클릭해도 안 떨어지게
            Debug.Log("마우스 클릭! 큐브가 떨어집니다 🚀");
        }
    }
}
