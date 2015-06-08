
/*
 * Unity3D脚本(C#):楼盘实体描述类
 * Author:秦元培
 * Date：2015年6月8日
 */
 
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Builds
{

	/// <summary>
	/// 楼盘ID
	/// </summary>
	private string m_id;
	public string ID 
	{
	  get { return m_id;}
	  set { m_id = value;}
	}

	/// <summary>
	/// 楼盘名称
	/// </summary>
	private string m_name;
	public string Name 
	{
	  get { return m_name;}
	  set { m_name = value;}
	}

	/// <summary>
	/// 楼盘描述
	/// </summary>
	private string m_desc;
	public string Description 
	{
	  get { return m_desc;}
	  set { m_desc = value;}
	}

	/// <summary>
	/// 楼盘地址
	/// </summary>
	private string m_address;
	public string Address 
	{
	  get { return m_address;}
	  set { m_address = value;}
	}

	/// <summary>
	/// 公交路线
	/// </summary>
	private string m_route;
	public string Route
	{
	  get { return m_route;}
	  set { m_route = value;}
	}

	/// <summary>
	/// 驾驶时间
	/// </summary>
	private string m_time;
	public string DriveTime 
	{
	  get { return m_time;}
	  set { m_time = value;}
	}

	/// <summary>
	/// 楼盘封面大图
	/// </summary>
	private string m_cover;
	public string Cover 
	{
	  get { return m_cover;}
	  set { m_cover = value;}
	}

	/// <summary>
	/// 楼盘小图
	/// </summary>
	private string m_small;
	public string Small
	{
	  get { return m_small;}
	  set { m_small = value;}
	}

	/// <summary>
	/// 楼盘场景资源
	/// </summary>
	private string m_source;
	public string Source
	{
	  get { return m_source;}
	  set { m_source = value;}
	}

	/// <summary>
	/// 楼盘户型
	/// </summary>
	private List<House> m_houses;
	public List<House> Houses 
	{
	  get { return m_houses;}
	  set { m_houses = value;}
	}
}
