using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카멜명명 법
public class Player : MonoBehaviour // class이름은 대문자로 시작 새로운 단어가 나오면 대문자로 시작
{

    public GameManager gameManager;
    public float speed = 10f;
    private Rigidbody playerRigidbody;  // 변수이름은 첫글자는 소문자

    // 게임이 처음 시작되었을 때 한번 실행
    void Start()  // 함수는 첫글자가 대문자
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // 화면이 한번 깜빡일 때 한번 실행
    // 영화 초당 24프레임 모바일 1초 30프레임 PC게임 1초 60프레임
    // 콘솔 게임 1초 30프레임
    // 1초에 대략 60번 실행 but 사양에 따라 다름
    // 몇 번 실행 되는지는 정해져 있지 않음
    void Update()
    {
        if(gameManager.isGameOver == true)
        {
            return;
        }
        //if (Input.GetKey(KeyCode.W))
        //{
        //    playerRigidbody.AddForce(speed, 0, 0);  // 이 코드 보다는 아래 코드가 더 효율적이고 우아함
        //}


        // A <-                 -> D
        // -1.0  -0.5  0   0.5  1.0
        // 조이스틱을 왼쪽으로 살살 밀면 
        float inputX = -Input.GetAxis("Horizontal"); // Horizontal 조이스틱 대응 가능, 조이스틱처럼 살짝 미는걸 구현하기 위해 숫자로 받음

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        //playerRigidbody.AddForce(inputX * speed, 0, inputZ * speed);  // 이거는 힘을 주는 경우(관성이 있음)
        Vector3 velocity = new Vector3(inputX, 0, inputZ); // 이거는 속도값을 바로 줌(관성이 없음)

        // (inputX * speed,0,inputZ * speed)
        velocity = velocity * speed;

        velocity.y = fallSpeed;

        //(inputX * speed, fallSpeed, inputZ * speed)
        playerRigidbody.velocity = velocity;

        // 조이스틱
    }
}
