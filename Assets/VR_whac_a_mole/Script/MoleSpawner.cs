using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    [SerializeField]
    private MoleFSM[] moles;    //맵에 존재하는 두더지들
    [SerializeField]
    private float spawnTime;  //두더지 등장 주기
    // Start is called before the first frame update

    
    public void Start()
    {
        StartCoroutine("SpawnMole");
    }

    private IEnumerator SpawnMole(){
        while(true){
            int index = Random.Range(0, moles.Length);
            //0~Moles.Length-1중 임의의 숫자 선택
            moles[index].ChangeState(MoleState.MoveUp);

            //spawnTime 시간동안 대기
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
