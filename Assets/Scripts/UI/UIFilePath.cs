
/*
 * Unity3D脚本(C#):UI各个控件的路径
 * Author:张驰前
 * Date：2015/6/8
 */

using UnityEngine;
using System.Collections;

//UI界面各个控件的路径
public static class UIFilePath{

	//户型选择场景UI相关物体的路径
	public static string HuXingScenceTop="Canvas3D/Background/Top/";//户型场景上侧
	public static string HuXingScenceShadow="Canvas3D/Background/Shadow/";//不同户型的背景
	public static string HuXingScenceRight="Canvas3D/Background/Right/";//户型场景的右侧
	public static string HuXingScenceTitle="Canvas3D/Background/Title/";//户型的标题

	//家具装修场景UI相关物体的路径
	public static string FurnitureScenceBackground="Canvas2D/Background/";//家具装修场景背景
	public static string FurnitureScenceSelectFurniture="Canvas2D/Background/SelectFurniture/BtnClose/";//选择家具窗口关闭
	public static string FurnitureScenceFurnitureGrid="Canvas2D/Background/SelectFurniture/FurnitureGrid/";//选择家具窗口展示家具
	public static string FurnitureScenceFurniturePanelDIY="Canvas2D/Background/PanelDIY/";//为客户量身定制的装修方案一栏
	public static string FurnitureScenceBtnBackBuilds = "Canvas2D/Background/BtnBackBuilds";//返回楼盘
	public static string FurnitureScenceBackMainUI="Canvas2D/Background/BtnBackMenu/";//返回主界面
	public static string FurnitureScenceBtnChangeStyle="Canvas2D/Background/BtnChangeStyle/";//更换风格
	public static string FurnitureScenceBtnDIYStyle="Canvas2D/Background/BtnDIYStyle/";//个人定制


	public static string FurnitureScenceViewerPanel="Canvas2D/Background/ViewerPanel";//人物漫游视觉选择
	public static string FurnitureScenceTextuesPanel="Canvas2D/Background/TextuesPanel";//颜色和纹理选择
	public static string FurnitureScenceFurniturerPanel="Canvas2D/Background/FurniturerPanel";//家居风格选择

}