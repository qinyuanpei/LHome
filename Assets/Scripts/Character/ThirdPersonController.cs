using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThirdPersonController : MonoBehaviour {

	//the character controiller
	private CharacterController controller;

	//the animation clip
	public AnimationClip Idle;
	public AnimationClip Walk;
	public AnimationClip Run;

	//the moveType of the Player
	public enum MoveType
	{
		Walk,
		Run,
	}

	public MoveType Type;

	//the speed of the player
	private float speed;

	//the animation of the player
	private AnimationClip moveClip;

	//the speed to move or run
	public float WalkSpeed=0.25f;
	public float RunSpeed=1.50f;

	Button btn;

	void Start () 
	{
		//get the character controller
		controller=GetComponent<CharacterController>();
		//set the moveType
		SetMoveType(Type);
	}


	void Update () 
	{
		if(!controller) return;
		//get the AxisRaw of X and Y
		float h=Input.GetAxisRaw("Horizontal");
		float v=Input.GetAxisRaw("Vertical");
		//get the forward and right
		Vector3 forward=Camera.main.transform.TransformDirection(Vector3.forward);
		forward.y=0;
		Vector3 right=new Vector3(forward.z,0,-forward.x);
		//get the move direction
		Vector3 target=h*right+v*forward;
		//Debug.Log (target);
		//idle or move
		if(target==Vector3.zero){
			animation.CrossFade(Idle.name,0.25f);
		}else{
			transform.rotation=Quaternion.LookRotation(target,Vector3.up);
			animation.CrossFade(moveClip.name,0.25f);
			controller.Move(target.normalized * speed * Time.deltaTime );
		}
	}

	public void SetMoveType(MoveType type)
	{
		switch(type)
		{
			case MoveType.Walk:
				speed=WalkSpeed;
				moveClip=Walk;
				break;
		    case MoveType.Run:
				speed=RunSpeed;
				moveClip=Run;
				break;
		}
	}
}
