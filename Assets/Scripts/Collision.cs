using UnityEngine;


public class Collision : MonoBehaviour {

    [SerializeField] SpriteRenderer SR; 
    bool HasPackage; // Box = Package
    float SlowSpeed = 2f;
    float normalSpeed;
    int Boxes = 0;

    private void Start() {
        // Set car color
        SR.color = Color.blue;
        normalSpeed = FindObjectOfType<CarMovement>().MoveSpeed;
    }
    
    private void NormalSpeed(){
        FindObjectOfType<CarMovement>().MoveSpeed = normalSpeed;
    }
    private void OnCollisionEnter2D(Collision2D other) {

        // Collision check and change properties
        if(other.transform.tag == "Box"){
            HasPackage = true;
            Boxes++;
            Destroy(other.gameObject);
            FindObjectOfType<CreateObjects>().CreateBox();
            FindObjectOfType<CreateObjects>().CreateObstacles(FindObjectOfType<CreateObjects>().Diffucilty);
            FindObjectOfType<Score>().score++;
        }

        if(other.transform.tag == "Obstacle"){
            FindObjectOfType<CarMovement>().MoveSpeed = SlowSpeed;
            Invoke("NormalSpeed",2f);
            
        }
        
        if(other.transform.tag == "Person"){

            if(HasPackage){
                FindObjectOfType<Score>().second+=(3f*Boxes);
                Boxes = 0;
                HasPackage = false;
            }
 
        }
    }


}