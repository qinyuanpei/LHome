

/*
 * Unity3D脚本(C#):户型选择场景的界面菜单的控制
 * Author:张驰前
 * Date：2015/6/8
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MenuController1 : MonoBehaviour {

	//切换户型按钮
	Button selectHuXingBtn;

	//户型选择按钮
	Button HuXingSelectBtn;

	//返回楼盘按钮
	Button backLouPanBtn;

	//进入家具装修场景按钮
	Button insertBtn;

	Text huXingName;//户型名称文本框
	Image huXingBG;//户型的背景图片

	// Use this for initialization
	void Start () {

		//获取到用户选择场景的各个控件
		selectHuXingBtn = GameObject.Find ("Canvas3D/Background/Shadow/Image").GetComponent<Button>();
		HuXingSelectBtn = GameObject.Find (UIFilePath.HuXingScenceTop+"NtnSelect").GetComponent<Button>();//获取户型选择Button
		huXingName = GameObject.Find (UIFilePath.HuXingScenceTitle+"Text").GetComponent<Text>();//获取户型名称文本Text

		insertBtn= GameObject.Find (UIFilePath.HuXingScenceRight+"BtnGo").GetComponent<Button>();//获取进入家具装修场景Button
		backLouPanBtn = GameObject.Find (UIFilePath.HuXingScenceTop+"NtnBack").GetComponent<Button>();//获取返回楼盘Button

		//给户型选择场景的各个控件添加相应的事件
		EventTriggerListener.GetEventTriggerListener (insertBtn.gameObject).PointerDown= ClickGo;//点击转到家具装饰场景
		EventTriggerListener.GetEventTriggerListener (backLouPanBtn.gameObject).PointerDown = BackLouPan;//点击返回到楼盘选择界面
	}

	void Update(){

	}


	//由户型选择场景加载到家具装修场景
	void ClickGo(GameObject go){
		Application.LoadLevel ("HouseDIY");
	}

	//由户型选择场景加载到返回楼盘场景
	void BackLouPan(GameObject go){
		Application.LoadLevel ("SelectBuilds");
	}

}
