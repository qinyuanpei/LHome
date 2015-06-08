
/*
 * Unity3D脚本(C#):自定义鼠标脚本
 * Author:秦元培
 * Date：2015年5月25日
 */
 
using UnityEngine;
using System.Collections;

public class CursorConfig : MonoBehaviour 
{
	/// <summary>
	/// 正常状态下的鼠标指针贴图
	/// </summary>
	private Texture texNormal;

	/// <summary>
	/// 选中物体时的鼠标指针贴图
	/// </summary>
	private Texture texSelect;

	/// <summary>
	/// 当前实例	
	/// </summary>
	public static CursorConfig Instance;

	/// <summary>
	/// 鼠标类型枚举
	/// </summary>
	public enum CursorType
	{
		Normal,
		Select
	}

	/// <summary>
	/// 当前鼠标指针贴图
	/// </summary>
	private Texture tex;

	void Awake () 
	{
		//texNormal=(Texture)Resources.Load(StaticConfig.UIFilePath + "ICON/mouse_0");
		//texSelect=(Texture)Resources.Load(StaticConfig.UIFilePath + "ICON/mouse_1");

		Instance=this;
		//禁用默认鼠标指针
		Screen.showCursor=false;
		//设置鼠标指针
		SetCursorType(CursorType.Normal);

	}
	
	void Start()
	{


	}

	void OnGUI()
	{
		Vector3 mousePos=Input.mousePosition;
		GUI.DrawTexture(new Rect(mousePos.x-16,Screen.height-mousePos.y-16,32,32),tex);
	}

	public void SetCursorType(CursorConfig.CursorType type)
	{
		switch(type)
		{
			case CursorType.Normal:
				tex=texNormal;
				break;
			case CursorType.Select:
				tex=texSelect;
				break;
		}
	}
}
