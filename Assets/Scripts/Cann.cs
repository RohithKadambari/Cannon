using UnityEngine;

public class Cann : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float upwardspeed;
    public Transform Muzzle;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screentowp();
        if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
        
    }
    
    
    void screentowp()
    {
        
        Vector3 mousePosition = Input.mousePosition;

        mousePosition.z = 10f;

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 direction = worldPosition - transform.position;

        direction.z = 10;

        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, direction);

        transform.rotation = targetRotation;
        
       }
    void Shoot()
    {
      GameObject BulletInstance=Instantiate(BulletPrefab,Muzzle.position,Quaternion.identity);
      Rigidbody2D bulletRb=BulletInstance.GetComponent<Rigidbody2D>();
      Vector2 velocity= transform.up*upwardspeed;
      bulletRb.linearVelocity = velocity;
    }
}


