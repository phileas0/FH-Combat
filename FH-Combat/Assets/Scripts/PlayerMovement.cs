using UnityEngine;

public class PlayerMovement : MonoBehaviour
    {
        public float movespeed;

        private float horizontal;

        private CharacterController controller;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxisRaw("Horizontal") * movespeed;
        Vector3 move = new Vector3(0,0,horizontal); 

        controller.Move(move*Time.deltaTime); 
    }
}


