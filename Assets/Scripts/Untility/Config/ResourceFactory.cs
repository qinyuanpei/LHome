
/*
 * Unity3D脚本(C#):资源工具类
 * Author:秦元培
 * Date：2015年6月9日
 */
 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public static class ResourceFactory
{
	/// <summary>
	/// 从一张贴图创建精灵
	/// </summary>
	/// <returns>The sprite form texture.</returns>
	public static Sprite CreateSpriteFormTexture(string resourcePath)
	{
		Texture2D tex2d=(Texture2D)Resources.Load(resourcePath);
		Sprite sprite=Sprite.Create(tex2d,new Rect(0,0,tex2d.width,tex2d.height),new Vector2(0.5f,0.5f));
		return sprite;
	}
}
