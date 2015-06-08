
/*
 * Unity3D脚本(C#):家具模型批处理插件
 * Author:秦元培
 * Date：2015年5月27日
 */
 
using UnityEngine;
using System.Collections;
using UnityEditor;

public class ModelTools : MonoBehaviour 
{
	[MenuItem("Export/Export Prefab----快速制作家具预设")]
	public static void ExportPrefab()
	{
		Object[] objects=Selection.GetFiltered(typeof(Object),SelectionMode.DeepAssets);
		if(objects.Length<0) return;
		foreach(Object obj in objects)
		{
			//获取文件路径
			string filePath=AssetDatabase.GetAssetPath(obj);
			//获取文件名
			string fileName=filePath.Substring(filePath.LastIndexOf("/")+1,filePath.Length-filePath.LastIndexOf("/")-1);
			//去除扩展名
			fileName=fileName.Substring(0,fileName.LastIndexOf("."));
			if(filePath.EndsWith(".FBX") || filePath.EndsWith(".fbx"))
			{
				//为模型增加碰撞器
				ModelImporter importer=(ModelImporter)AssetImporter.GetAtPath(filePath);
				importer.addCollider=true;
				importer.importAnimation=false;
				//重新导入模型
				AssetDatabase.ImportAsset(filePath);
				GameObject prefab=(GameObject)PrefabUtility.CreatePrefab("Assets/Resources/Prefabs/" + fileName + ".prefab",(GameObject)obj);
				prefab.tag="RayCheckObject";
				//禁用当前动画组件

				//修改着色器
				Renderer render=prefab.GetComponent<Renderer>();
				if(render!=null && render.sharedMaterial!=null){
					render.sharedMaterial.shader=Shader.Find("Transparent/Cutout/Bumped Diffuse");
				}
				//绑定脚本组件
				//prefab.AddComponent<MouseRayCheck>();
				//prefab.AddComponent<JiaJuToolTip>();
				//导入当前预设文件
				AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(prefab));
			}
		}

		//刷新本地资源
		AssetDatabase.Refresh();
	}

}
