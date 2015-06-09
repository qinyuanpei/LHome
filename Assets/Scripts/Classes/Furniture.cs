
/*
 * Unity3D脚本(C#):家具实体描述类
 * Author:秦元培
 * Date:2015年6月8日
 */
 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Furniture
{
	/// <summary>
	/// 家具ID
	/// </summary>
	private string m_id;
	public string ID 
	{
	  get { return m_id;}
	  set { m_id = value;}
	}

	/// <summary>
	/// 家具预设体
	/// </summary>
	private string m_prefab;
	public string Prefab
	{
	  get { return m_prefab;}
	  set { m_prefab = value;}
	}

	/// <summary>
	/// 家居贴图
	/// </summary>
	private Sprite m_texture;
	public Sprite Texture 
	{
	   get { return m_texture;}
	   set { m_texture = value;}
	}
}
