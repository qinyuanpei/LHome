
/*
 * Unity3D脚本(C#):装修风格
 * Author:秦元培
 * Date:2015年6月9日
 */
 
using UnityEngine;
using System.Collections;

public class Style
{
	/// <summary>
	/// 风格ID
	/// </summary>
	private string m_id;
	public string ID
	{
	  get { return m_id;}
	  set { m_id = value;}
	}

	/// <summary>
	/// 风格名称
	/// </summary>
	private string m_name;
	public string Name 
	{
	  get { return m_name;}
	  set { m_name = value;}
	}

	/// <summary>
	/// 风格资源
	/// </summary>
	private string m_resource;
	public string Resource
	{
	  get { return m_resource;}
	  set { m_resource = value;}
	}
}
