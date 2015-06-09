
/*
 * Unity3D脚本(C#):Unity3D室内装修风格导出插件
 * Author:秦元培
 * Date:2015年6月9日
 */
 
using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Xml;

public class ExportScener 
{
	[MenuItem("Export/ExportScene----将当前场景导出为Xml")]
	static void ExportGameObjects()
	{
		//获取保存路径
		string savePath=EditorUtility.SaveFilePanel("输出场景内物体","","New Resource","xml");
	}
}
