using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//지하에 대기, 지상에 대기, 지하-> 지상, 지상-> 지하 이동
public enum MoleState {UnderGround = 0, OnGround, MoveUp, MoveDown} //열거형
public class MoleFSM : MonoBehaviour
{
    [SerializeField]
    private float waitTimeOnGround; //지면에 올라와서 내려가기까지 기다리는 시간
    [SerializeField]
    private float limitMinY; //내려갈 수 있는 최소 y 위치
    [SerializeField]
    private float limitMaxY; //내려갈 수 있는 최대 y 위치

    private MoleMovement movement3D;  // 두더지 이동 클래스 선언

    public MoleState MoleState {private set; get;}
    // Start is called before the first frame update

    private void Awake() {
        movement3D = GetComponent<MoleMovement>();
        ChangeState(MoleState.UnderGround); //시작할 때는 땅에서
    }

    public void ChangeState(MoleState newState)
    {
        //코루틴을 이용한 유한상태기계: 플레이어, 적의 상태별 행동구현, 튜토리얼, 스텝 단위로 실행되는 시스템 등에 활용
        //이전에 재생중이던 상태 종료
        StopCoroutine(MoleState.ToString());
        //상태 변경
        MoleState = newState;
        //새로운 상태 재생
        StartCoroutine(MoleState.ToString());
    }

    //두더지가 바닥에서 대기하는 상태로 최초에 바닥 위치로 두더지 위치 설정
    private IEnumerator UnderGround(){
        //이동방향을 : (0, 0, 0) [정지]
        movement3D.MoveTo(Vector3.zero);
        //두더지의 y위치를 홀에 숨어있는 limitMin Y위치로 설정
        transform.position = new Vector3(transform.position.x, limitMinY, transform.position.z);

        yield return null;

    }

    //두더지가 홀 밖으로 나와있는 상태로 waitTimeOnGround 동안 대기
    private IEnumerator OnGround(){
        //이동방향을 : (0, 0, 0) [정지]
        movement3D.MoveTo(Vector3.zero);
        //두더지의 y위치를 홀 밖으로 나와있는 limitMaxY위치로 설정
        transform.position = new Vector3(transform.position.x, limitMaxY, transform.position.z);

        //waitTimeOnGround 시간동안 대기
        yield return new WaitForSeconds(waitTimeOnGround);

        //두더지의 상태를 MoveDown으로 변경
        ChangeState(MoleState.MoveDown);
    }

    private IEnumerator MoveUp(){
        //이동방향 (0, 1, 0) [위]
        movement3D.MoveTo(Vector3.up);

        while(true){
            //두더지의 y 위치가 limitMaxY에 도달하면 상태 변경
            if(transform.position.y >= limitMaxY){
                //OnGround 상태로 변경
                ChangeState(MoleState.OnGround);
            }
            yield return null;
        }
    }

    //두더지가 홀로 들어가는 상태
    private IEnumerator MoveDown(){
        movement3D.MoveTo(Vector3.down);

        while(true){
            //두더지의 y위치가 limeitMinY에 도달하면 반복문 중지
            if(transform.position.y <= limitMinY){
                ChangeState(MoleState.UnderGround);
            }
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        StopCoroutine(MoleState.ToString());
        StartCoroutine("MoveDown");
        Debug.Log("충돌 했습니다");

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
