# 2025-VR-Simulation-2

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastClick_a : MonoBehaviour
{
    private bool isColorChanged = false;

    // 인스펙터에서 컴포넌트 드래그앤드랍 또는 선택할수있도록
    public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 코루틴을 사용하기위해
    IEnumerator ChangeMaxParticles()
    {
        // 메인이라는 변수에 대입
        var main = particleSystem.main;

        // 원래 값 가져오기. 어떻게 ?  main에서 
        int originalMaxParticles = main.maxParticles;

        // 1000으로 바꾸기
        main.maxParticles = 1000;

        // 1초 기다려!
        yield return new WaitForSeconds(1f);

        // 원래대로(0으로)
        main.maxParticles = originalMaxParticles;
    }

    // 레이를 쏘고, 물체에 맞으면, 정보(태그)를 가져오고, 오브젝트 정보를 가져오고,
    // 그 오브젝트의 Material의 컬러를 랜덤으로 Set Color
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isColorChanged)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log($"Ray: Hit: Name: {hit.collider.name}");
                Debug.Log($"Ray: Hit: Tag: {hit.collider.tag}");

                // 만약에 태그를 비교해서, cube-1이면
                if (hit.collider.CompareTag("cube-1"))
                {
                    // scale 0으로 변경
                    hit.collider.transform.localScale = Vector3.zero;

                    // 파티클을 잠깐 생성하기
                    // 타이머!
                    // 근데 오늘은 코루틴
                    StartCoroutine(ChangeMaxParticles());
                }   
                    
                // Change color
                Renderer rend = hit.collider.GetComponent<Renderer>();
                if (rend != null)
                {
                    // 무언가 맞은 상황임
                    Color randomColor = new Color(Random.value, Random.value, Random.value);

                    rend.material.color = randomColor;
                    
                }
            }
        }


    }
}

```
