using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class PlayerMovement : MonoBehaviour
{
	public float movementVelocityX, movementVelocityY;
	public float movementAccelerationX, movementAccelerationY;
	public float jumpPower;


	private bool isMovingAndChangingGravity = false;
	private Vector3 targetPos;
	private Quaternion targetRot;
	// private Vector3 targetPoint;
	// private Vector3 gravityDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (Controller.IsGravityChange())
    	{
    		Vector3 screenPos = Controller.GetInputGracityChange();
			Ray ray = Camera.main.ScreenPointToRay(screenPos);
			RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
				Debug.DrawLine(ray.origin, hit.point, Color.yellow);
            	Debug.Log("Debug: Raycast hit\n");

            	targetPos = hit.point;
            	// targetRot = transform.rotation * Quaternion.FromToRotation(transform.up, hit.normal);
            	targetRot = transform.rotation * Quaternion.FromToRotation(transform.up, hit.transform.up);
            	isMovingAndChangingGravity = true;
        	}
    	}

    	if (isMovingAndChangingGravity)
    	{
        	transform.position = Vector3.MoveTowards(transform.position, targetPos, 20 * Time.deltaTime);
        	// Rotate our transform a step closer to the target's.
	        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, 80 * Time.deltaTime);
    	}


    	// Vector3 gravityDirection = new Vector3(0, -1, 0);
    	// Vector3 velocityVector;

    	// if (Controller.GetJump()) movementVector += new Vector3(0, jumpPower, 0);

    	// transform.position += velocityVector * Time.deltaTime;

    	// velocityVector += 9.81 * gravityDirection * Time.deltaTime;




    	// Vector2 curSpeed = a * targetSpeed + (1-a) * curSpeed;

		// float hMovement = Controller.GetHorizontal() * speed * Time.deltaTime;
		// float vMovement = Controller.GetVertical() * speed * Time.deltaTime;

		// transform.Translate(hMovement);
        
    }

}
