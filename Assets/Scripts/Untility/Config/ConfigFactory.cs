
/*
 * Unity3D脚本(C#):配置文件静态工厂类
 * Author:秦元培
 * Date:2015年6月8日
 */
 
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public static class ConfigFactory
{
	/// <summary>
	/// 楼盘配置文件路径
	/// </summary>
	private static string BuildsConfigFile="Configs/config_builds";

	/// <summary>
	/// 从配置文件中加载楼盘信息
	/// </summary>
	/// <returns>The builds form config.</returns>
	public static List<Building> LoadBuildsFormConfig()
	{
		//从本地加载楼盘配置文件
		XmlDocument xmlDoc=new XmlDocument();
		xmlDoc.LoadXml(((TextAsset)(Resources.Load(ConfigFactory.BuildsConfigFile))).text);
		//获取根节点
		XmlElement rootElement=xmlDoc.DocumentElement;
		//获取楼盘节点
		XmlNodeList nodes=rootElement.SelectNodes("/Buildings/Building");
		//创建一个列表以存储楼盘信息
		List<Building> mBuildings=new List<Building>();
		//解析楼盘信息
		foreach(XmlElement xe1 in nodes)
		{
			Building mBuilding=new Building();
			mBuilding.ID=xe1.GetAttribute("ID");
			mBuilding.Name=xe1.GetAttribute("Name");
			mBuilding.Description=xe1["Description"].InnerText;
			mBuilding.Address=xe1["Address"].InnerText;
			mBuilding.Route=xe1["Route"].InnerText;
			mBuilding.DriveTime=xe1["DriveTime"].InnerText;
			mBuilding.Cover=ResourceFactory.CreateSpriteFormTexture(xe1["Cover"].InnerText);
			mBuilding.Small=ResourceFactory.CreateSpriteFormTexture(xe1["Small"].InnerText);
			mBuilding.Resource=xe1["Resource"].InnerText;
			//创建一个列表以存储户型信息
			List<House> mHouses=new List<House>();
			//解析户型信息
			foreach(XmlElement xe2 in xe1["Houses"].ChildNodes)
			{
				House mHouse=new House();
				mHouse.ID=xe2.GetAttribute("ID");
				mHouse.Name=xe2.GetAttribute("Name");
				mHouse.Image=ResourceFactory.CreateSpriteFormTexture(xe2["Image"].InnerText);
				mHouse.Description=xe2["Description"].InnerText;
				mHouse.Price=xe2["Price"].InnerText;
				mHouse.Square=xe2["Square"].InnerText;
				mHouse.Resource=xe2["Resource"].InnerText;
				//创建一个列表以存储装修风格信息
				List<Style> mStyles=new List<Style>();
				//解析装修风格
				foreach(XmlElement xe3 in xe2["Styles"].ChildNodes)
				{
					Style mStyle=new Style();
					mStyle.ID=xe3.GetAttribute("ID");
					mStyle.Name=xe3.GetAttribute("Name");
					mStyle.Resource=xe3["Resource"].InnerText;
					//添加到列表
					mStyles.Add(mStyle);
				}
				//设置户型装修风格
				mHouse.Styles=mStyles;
				//添加到列表
				mHouses.Add(mHouse);
			}
			//设置楼盘户型列表
			mBuilding.Houses=mHouses;
			//添加到列表
			mBuildings.Add(mBuilding);
		}
	    //返回楼盘信息
		return mBuildings;
	}
}
