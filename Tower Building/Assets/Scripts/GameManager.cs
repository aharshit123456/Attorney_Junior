using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    [SerializeField] private Transform blockPrefab;
    [SerializeField] private Transform blockHolder;

    private Transform currentBlock = null ;
    private Rigidbody2D currentRigidBody ;
    private Vector2 BlockStartPosition = new Vector2(0f, 4f) ;
    private float blockSpeed = 8f ;
    private float blockSpeedIncrement = 0.5f ;





    // Start is called before the first frame update
    void Start(){
        SpawnNewBlock();
        
    }

    private void SpawnNewBlock(){
        currentBlock = Instantiate(blockPrefab, blockHolder);
        currentBlock.position = BlockStartPosition;
        currentBlock.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        currentRigidBody = currentBlock.GetComponent<Rigidbody2D>() ;

        blockSpeed += blockSpeedIncrement ;
    }



    // Update is called once per frame
    void Update(){

        

    }
}
