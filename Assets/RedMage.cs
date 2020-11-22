using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMage : MonoBehaviour
{
    public static int health = 100;
    bool canShoot = true;
    public float speed;
    public float fireballSpeed;
    public Rigidbody2D fireball;
    Rigidbody2D rb;
    public Sprite Classic;
    public Sprite WandMage;
    public int skin = 0;
     
    void Start () {
        rb = GetComponent <Rigidbody2D> ();
    }
     
    void FixedUpdate () {
        if(health <= 0){
            Destroy(gameObject);
        }
         if(Input.GetKey(KeyCode.UpArrow)) {
             transform.Translate(Vector2.up * speed * Time.deltaTime);
         }
 
         if(Input.GetKey(KeyCode.LeftArrow)) {
             transform.Translate(Vector2.left * speed * Time.deltaTime);
         }
 
         if(Input.GetKey(KeyCode.DownArrow)) {
             transform.Translate(Vector2.down * speed * Time.deltaTime);
         }
 
         if(Input.GetKey(KeyCode.RightArrow)) {
             transform.Translate(Vector2.right * speed * Time.deltaTime);
         }
         
         if(Input.GetKeyDown(KeyCode.L)) {
             if(canShoot == true){
                var fireballInst = Instantiate(fireball, transform.position, Quaternion.Euler(new Vector2(0, 0)));
                fireballInst.velocity = new Vector2(fireballSpeed, 0);
                canShoot = false;
                StartCoroutine(ShootDelay());
             }
         }
    }

    public void reskin(int skin){
        if(skin == 0){
            this.GetComponent<SpriteRenderer>().sprite = Classic;
        }
        else if(skin == 1){
            this.GetComponent<SpriteRenderer>().sprite = WandMage;
        }
    }
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(0.75f);
        canShoot = true;
    }
    
}
