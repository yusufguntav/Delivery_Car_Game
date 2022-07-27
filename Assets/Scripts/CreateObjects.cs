using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    [SerializeField] Texture2D ObstacleTexture;
    [SerializeField] Texture2D PersonTexture;
    [SerializeField] Texture2D BoxTexture;
    public int Diffucilty = 10;
    
    [HideInInspector] public GameObject Box;
    void Start()
    {
        CreateObstacles(Diffucilty);
        CreatePerson();
        CreateBox();
        
    }
     public void CreateBox(){
        // X,Y Position
        int RandomNumX = Random.Range(-15,15);
        int RandomNumY = Random.Range(-15,15);
        // Create Box
        Box = new GameObject("Box");
        Box.tag = "Box";
        // Add SpriteRenderer
        SpriteRenderer SpriteR = Box.AddComponent<SpriteRenderer>();
        // Add BoxCollider2D
        BoxCollider2D BoxCld = Box.AddComponent<BoxCollider2D>();
        // Set BoxCld size
        BoxCld.size = new Vector2(2.6f,2.6f);
        // Add Rigidbody2D
        Rigidbody2D RB2D = Box.AddComponent<Rigidbody2D>();
        RB2D.mass = 20;
        RB2D.gravityScale = 0;
        // Set Box scale and position
        Box.transform.localScale = new Vector3(.8f,.8f,.8f); 
        Box.transform.position = new Vector3(RandomNumX,RandomNumY,0);
        // Set sprite
        SpriteR.sprite = Sprite.Create(BoxTexture,new Rect(0.0f, 0.0f, BoxTexture.width, BoxTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
    }
    private void CreatePerson(){
        // X,Y Position
        int RandomNumX = Random.Range(-15,15);
        int RandomNumY = Random.Range(-15,15);  
         // Create Person
        GameObject Person = new GameObject("Person");
        Person.tag = "Person";
        // Add SpriteRenderer
        SpriteRenderer SpriteR = Person.AddComponent<SpriteRenderer>();
        // Add CircleCollider2D
        CircleCollider2D CircCld = Person.AddComponent<CircleCollider2D>();
        // Set CircCld radius
        CircCld.radius = .18f;
        // Add Rigidbody2D
        Rigidbody2D RB2D = Person.AddComponent<Rigidbody2D>();
        RB2D.mass = 20;
        RB2D.gravityScale = 0;
        // Set Person scale and position
        Person.transform.localScale = new Vector3(3,3,3); 
        Person.transform.position = new Vector3(RandomNumX,RandomNumY,0);
        // Set sprite
        SpriteR.sprite = Sprite.Create(PersonTexture,new Rect(0.0f, 0.0f, PersonTexture.width, PersonTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
        SpriteR.color = Color.green;

    }
    public void CreateObstacles(int diffucilty){
        
        for (int i = 0; i < diffucilty; i++)
        {
        // X,Y Position
        int RandomNumX = Random.Range(-15,15);
        int RandomNumY = Random.Range(-15,15);
        // Create Obstacle
        GameObject Obstacle = new GameObject("OBSTACLE");
        Obstacle.tag = "Obstacle";
        // Add SpriteRenderer
        SpriteRenderer SpriteR = Obstacle.AddComponent<SpriteRenderer>();
        // Add CircleCollider2D
        CircleCollider2D CirCold = Obstacle.AddComponent<CircleCollider2D>();
        // Set radius CirCold
        CirCold.radius = .18f;
        // Add Rigidbody2D
        Rigidbody2D RB2D = Obstacle.AddComponent<Rigidbody2D>();
        RB2D.mass = 1000;
        RB2D.gravityScale = 0;
        // Set obstacle scale and position
        Obstacle.transform.localScale = new Vector3(5,5,5); 
        Obstacle.transform.position = new Vector3(RandomNumX,RandomNumY,0);
        // Set sprite
        SpriteR.sprite = Sprite.Create(ObstacleTexture,new Rect(0.0f, 0.0f, ObstacleTexture.width, ObstacleTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
        SpriteR.color = Color.red;
        }
        
    }
}
