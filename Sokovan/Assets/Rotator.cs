using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{


    //public Transform myTransform;
    // Start is called before the first frame update
    //void Start()
    //{
    //    myTransform.Rotate(60, 60, 60);
    //    // transform.Rotate(60, 60, 60);  // short-cut : Transform 변수를 만들 필요없이 가능
    //}

    // Update는 대략 1초에 60번
    void Update()
    {
        // 1번에 60도
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);

        // Time.deltaTime 은 화면이 한 번 깜박이는 시간 = 한 프레임의 시간
        // 화면을 60번 깜빡이면 (초당 60프레임) 1/60 초
        // 화면을 200번 깜빡이면 (초당 200프레임) 1/200 초
    }

    // 60 * 60 = 3600 1초에 3600도 회전

    // 1초에 총 1m

    // Update 함수는 화면이 한번 깜빡이면 실행됨
    // Update { 한번에 1m }

    // 조선컴 : 1초에 30번
    // 한번에 1m * 30 => 1초에 30m ==> 30 * (1/30) = 1m



    // 고사양 컴퓨터: 1초에 60번
    // 한번에 1m * 60 => 1초에 60m ==> 60 * (1/60) = 1m
    // 1m * (1/60) * 60 = 1m
}
