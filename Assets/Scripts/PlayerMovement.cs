using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class PlayerMovement : MonoBehaviour
{
	public float movementVelocityX, movementVelocityY;
	public float movementAccelerationX, movementAccelerationY;
	public float jumpPower;

	// private Vector3 gravityDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 gravityDirection = new Vector3(0, -1, 0);
    	Vector3 velocityVector;

    	if (Controller.GetJump()) movementVector += new Vector3(0, jumpPower, 0);

    	transform.position += velocityVector * Time.deltaTime;

    	velocityVector += 9.81 * gravityDirection * Time.deltaTime;

    	// Vector2 curSpeed = a * targetSpeed + (1-a) * curSpeed;

		// float hMovement = Controller.GetHorizontal() * speed * Time.deltaTime;
		// float vMovement = Controller.GetVertical() * speed * Time.deltaTime;

		// transform.Translate(hMovement);
        
    }

}
