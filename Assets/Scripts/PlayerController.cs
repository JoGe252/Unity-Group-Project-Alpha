using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30;
    public float xRange = 15;
    public float horizontalInput;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); 
        }
        if (transform.position.x >xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); 
        }
        // get user's input
        horizontalInput = Input.GetAxis("Horizontal");
        // move player right and left
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        // move player up and down 
        // launch projectile
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
