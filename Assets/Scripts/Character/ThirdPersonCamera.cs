using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

	//the target to foloow
	public Transform Target;

	//the max angle of Y
	public float MaxAngleY=360;

	//the min angle of Y
	public float MinAngleY=-360;

	//the max distance 
	public float MaxDistance=20;

	//the min distance
	public float MinDistance=0.5f;

	//the distance
	public float Distance=5.0f;

	//the zoom speed
	public float ZoomSpeed=0.25f;

	//the rotate speed
	public float RotateSpeed=0.5f;

	//the angle of X and Y
	private float angleX;
	private float angleY;

	//the rotation
	private Quaternion rotation;

	public float Height=0.25f;
    

	void Start () 
	{
		//init the angleX and angleY
		angleX=Target.transform.eulerAngles.x;
		angleY=Target.transform.eulerAngles.y;
		//init the rotation
		rotation=Quaternion.Euler(angleY,angleX,0);

	}


	void Update () 
	{
		if(!Target) return;

		//rotate the camera
	 	if(Input.GetMouseButton(1)){
			angleX+=Input.GetAxis("Mouse X") * RotateSpeed;
			angleY-=Input.GetAxis("Mouse Y") * RotateSpeed;
			angleY=ClampAngle(angleY,MinAngleY,MaxAngleY);
			rotation=Quaternion.Euler(angleY,angleX,0);
		}

		//zoom the camera
		if(Input.GetAxis("Mouse ScrollWheel")!=0){
			Distance-=Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;
			Distance=Mathf.Clamp(Distance,MinDistance,MaxDistance);
		}

		//set the camera position and rotation
		transform.rotation=rotation;
		transform.position=rotation * new Vector3(0,Height,-1) * Distance + Target.position;
	}

	/// <summary>
	/// the function to clamps the angle.
	/// </summary>
	/// <returns>The angle.</returns>
	/// <param name="angle">Angle.</param>
	/// <param name="min">Minimum.</param>
	/// <param name="max">Max.</param>
	private float ClampAngle(float angle,float min,float max)   
	{  
		if(angle < -360) angle += 360;  
		if(angle >  360) angle -= 360;  
		return Mathf.Clamp (angle, min, max);  
	}  
}
