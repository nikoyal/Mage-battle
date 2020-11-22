using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMage : MonoBehaviour
{   
        public static int health = 100;
        bool canShoot = true;
        public Rigidbody2D fireball;
        public float fireballSpeed;
        public float speed;
        Rigidbody2D rb;
     
        void Start () {
            rb = GetComponent <Rigidbody2D> ();
        }
     
        void FixedUpdate () {
         if(health <= 0){
             Destroy(gameObject);
         }
         if(Input.GetKey(KeyCode.W)) {
             transform.Translate(Vector2.up * speed * Time.deltaTime);
         }
 
         if(Input.GetKey(KeyCode.A)) {
             transform.Translate(Vector2.left * speed * Time.deltaTime);
         }
 
         if(Input.GetKey(KeyCode.S)) {
             transform.Translate(Vector2.down * speed * Time.deltaTime);
         }
 
         if(Input.GetKey(KeyCode.D)) {
             transform.Translate(Vector2.right * speed * Time.deltaTime);
         }
         
        if(Input.GetKeyDown(KeyCode.Space)) {
             if(canShoot == true){
                var fireballInst = Instantiate(fireball, transform.position, Quaternion.Euler(new Vector2(0, 0)));
                fireballInst.velocity = new Vector2(fireballSpeed, 0);
                canShoot = false;
                StartCoroutine(ShootDelay());
             }
        }
    }
    IEnumerator ShootDelay(){
        yield return new WaitForSeconds(0.75f);
        canShoot = true;
    }
}
