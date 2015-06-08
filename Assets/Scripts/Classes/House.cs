
/*
 * Unity3D脚本(C#):户型实体描述类
 * Author:秦元培
 * Date：2015年6月8日
 */
 
using UnityEngine;
using System.Collections;

public class House
{
	/// <summary>
	/// 户型ID
	/// </summary>
	private string m_id;
	public string ID 
	{
	  get { return m_id;}
	  set { m_id = value;}
	}

	/// <summary>
	/// 户型名称
	/// </summary>
	private string m_name;
	public string Name 
	{
	  get { return m_name;}
	  set { m_name = value;}
	}

	/// <summary>
	/// 户型图片
	/// </summary>
	private string m_image;
	public string Image
	{
	  get { return m_image;}
	  set { m_image = value;}
	}

	/// <summary>
	/// 户型描述
	/// </summary>
	private string m_desc;
	public string Description 
	{
	  get { return m_desc;}
	  set { m_desc = value;}
	}

	/// <summary>
	/// 户型场景资源
	/// </summary>
	private string m_resource;
	public string Resource
	{
	  get { return m_resource;}
	  set { m_resource = value;}
	}
}
