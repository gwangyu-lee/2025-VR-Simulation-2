# 2025-VR-Simulation-2

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_b : MonoBehaviour
{

    // 마우스로 물체를 클릭하면, 그 물체 컬러를 랜덤하게 바꾸기
    // 마우스클릭,raycast, ray에 충돌한 그 물체 정보, null check, 그 물체의 Material의 컬러를 랜덤값 대입


    // 물체를 처음 한번만 클릭했을 때 컬러가 바뀌게 만들기
    // 하늘을 클릭하면 이거는 카운트안함. 왜? 물체의 컬러가 안바꼈으니까

    
    private bool isColorChanged = false;

    public ParticleSystem particleSystem;

    // 코루틴을 사용하기위한 syntax
    IEnumerator ChangeMaxParticles()
    {
        // Statement
        // 파티클 시스템이 뭔지?
        var main = particleSystem.main;
        // 이제부터 이 scope 안에서 main은 파티클시스템!!

        // 원래 기본 설정한 max particles 값을 가져옵니다!
        int originalMaxParticles = main.maxParticles;

        // max particles 1000으로
        main.maxParticles = 1000;

        // 몇초 기다려!
        yield return new WaitForSeconds(1f);

        // Statement
        // max particles 다시 원래 값으로
        main.maxParticles = originalMaxParticles;
        // main.maxParticles = 0;
    }

    void Update()
    {
        // 만약에 왼쪽 클릭하면
        if (Input.GetMouseButtonDown(0))
        {
            // 화면에서 마우스위치를 기준으로 Ray 생성
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Ray Hit 저장 변수
            RaycastHit hit;
            Debug.Log("Raycast: Left Button: Down");
            
            // Null Check
            if (Physics.Raycast(ray, out hit) )
            {
                Debug.Log("충돌이 일어났다!");
                Debug.Log($"Raycast: Hit: Object: {hit.collider.name}");
                Debug.Log($"Raycast: Hit: Tag: {hit.collider.tag}");

                // 태그가 cube-1 이라면?
                if (hit.collider.CompareTag("cube-1"))
                {
                    // 부딪힌애의 사이즈를 0으로!
                    hit.collider.transform.localScale = Vector3.zero;

                    // 파티클 max 1000으로 바꾸고
                    // 1초후에 0으로 변경!
                    StartCoroutine(ChangeMaxParticles());
                }

                // Ray와 충돌한 object 저장
                Renderer rend = hit.collider.GetComponent<Renderer>();
                if (rend != null && !isColorChanged)
                {
                    // 랜덤컬러 생성
                    Color randomColor = new Color(Random.value, Random.value, Random.value);
                    rend.material.color = randomColor;
                    isColorChanged = true;
                }
            }
            else
            {
                Debug.Log("충돌이 일어나지 않았다!");
            }
        }
    }
}
```


    }
}

```
