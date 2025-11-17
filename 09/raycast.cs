using UnityEngine;

public class RaycastClick : MonoBehaviour
{
    void Update()
    {
        // 마우스 왼쪽 버튼을 클릭했을 때
        if (Input.GetMouseButtonDown(0))
        {
            // 화면에서 마우스 위치를 기준으로 Ray(광선) 생성
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; // 충돌 정보 저장용 변수

            // 광선을 쏘고 무언가에 맞았는지 확인
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("충돌한 오브젝트: " + hit.collider.name);
                Debug.Log("충돌한 오브젝트 태그: " + hit.collider.tag);
                Debug.Log("충돌 위치: " + hit.point);

                // 💡 예시: 맞은 오브젝트 색 바꾸기
                Renderer rend = hit.collider.GetComponent<Renderer>();
                if (rend != null)
                {
                    Color randomColor = new Color(Random.value, Random.value, Random.value);

                    // 색상 적용
                    rend.material.color = randomColor;
                    // rend.material.color = Color.red;
                }
            }
            else
            {
                Debug.Log("아무것도 맞지 않았습니다.");
            }
        }
    }
}
