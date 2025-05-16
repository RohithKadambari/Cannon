using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.Rendering;

public class Falling : MonoBehaviour
{
    public GameObject CirclePrefab;
    public GameObject currentHoldingBall;
    public int initialSpawnCount=0;
    public int maxSpawnCount=4;
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& initialSpawnCount<maxSpawnCount)
        {
          currentHoldingBall =  Instantiate(CirclePrefab,mousetoworld(),Quaternion.identity);
          initialSpawnCount++;
          Debug.Log("position at"+mousetoworld());
        }
        if(Input.GetMouseButton(0))
        { 
            currentHoldingBall.transform.position=mousetoworld();


        }
        if(Input.GetMouseButtonUp(0))
        {
          Rigidbody2D currentHoldingballsrigidbody= currentHoldingBall.GetComponent<Rigidbody2D>();
          currentHoldingballsrigidbody.bodyType=RigidbodyType2D.Dynamic;
        }
    }
    public Vector3  mousetoworld()
    {
        Vector3 MousePos;
        MousePos=Input.mousePosition;
        MousePos.z=10;
      return Camera.main.ScreenToWorldPoint(MousePos);
    }
    
}
