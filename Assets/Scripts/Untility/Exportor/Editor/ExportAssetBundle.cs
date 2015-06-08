
/*
 * Unity3D脚本(C#)
 * Author:
 * Date：
 */
 
using UnityEngine;
using UnityEditor;
using System.Collections;

public class ExportAssetBundle
{

	private static string ExportPath=Application.dataPath+"/AssetBundle/";
	/// <summary>
	/// 输出AssetBundle
	/// </summary>
	[MenuItem("Export/ExportTotal----对物体整体打包")]
	static void ExportAll()
	{
		//获取保存路径
		string savePath=EditorUtility.SaveFilePanel("输出为AssetBundle","","New Resource","unity3d");
		if(string.IsNullOrEmpty(savePath)) return;
		//获取选择的物体
		Object[] objs=Selection.GetFiltered(typeof(Object),SelectionMode.DeepAssets);
		if(objs.Length<0) return;
		//打包
		BuildPipeline.BuildAssetBundle(null,objs,savePath,BuildAssetBundleOptions.CollectDependencies|BuildAssetBundleOptions.CompleteAssets);
		AssetDatabase.Refresh();
	}

	[MenuItem("Export/ExportSingle----对每个物体单独打包")]
	static void ExportSingle()
	{
		//获取选择的物体
		Object[] objs=Selection.GetFiltered(typeof(Object),SelectionMode.DeepAssets);
		if(objs.Length<0) return;
		//打包
		foreach(Object obj in objs)
		{
			string savePath=ExportPath+((GameObject)obj).name+".unity3d";
			BuildPipeline.BuildAssetBundle(obj,null,savePath,BuildAssetBundleOptions.CollectDependencies|BuildAssetBundleOptions.CompleteAssets);
			AssetDatabase.Refresh();
		}
	}

	[MenuItem("Export/ExportScene----输出当前场景")]
	static void ExportScene()
	{
		//获取保存路径
		string savePath=EditorUtility.SaveFilePanel("输出为AssetBundle","","New Resource","unity3d");
		if(string.IsNullOrEmpty(savePath)) return;
		string[] levels=new string[]{EditorApplication.currentScene};
		BuildPipeline.BuildStreamedSceneAssetBundle(levels,savePath,BuildTarget.StandaloneOSXIntel);
	}

}
