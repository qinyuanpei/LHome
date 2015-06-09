
/*
 * Unity3D脚本(C#):家具装饰场景界面菜单的控制
 * Author:张驰前
 * Date：2015/6/8
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController2 : MonoBehaviour {

	/// <summary>
	/// 用布尔变量控制点击按钮时界面显示或者隐藏
	/// </summary>
	//默认为true,既就是点击时显示界面
	bool viewerFlag=true;
	bool furnitureFlag=true;
	bool textuesFlag=true;
	bool personDIYFlag=true;

	bool option1ListFlag=true;
	bool option2ListFlag=true;
	bool optionPanelFlag=true;



	/// <summary>
	///家具装饰场景UI中的各个按钮 
	/// </summary>
	//添加家具Button
	Button btnFurniture;
	//视角选择Button
	Button btnViewer;
	//颜色和纹理Button
	Button btnTexture;
	//更换风格Button
	Button btnChangeStyle;
	//个人定制Button
	Button btnDIYStyle;
	//返回楼盘Button
	Button btnBackBuilds;
	//返回主界面Button
	Button btnBackMenu;


	/// <summary>
	///个人定制界面上的三个折合按钮
	/// </summary>
	Button btnFold1;
	Button btnFold2;
	Button btnFold3;


	/// <summary>
	/// 家具装饰场景中点击相应按钮的响应的的界面
	/// </summary>
	//视觉选择界面Panel
	GameObject viewerPanel;
	//添加家具界面
	GameObject furniturerPanel;
	//颜色和纹理选择界面
	GameObject textuesPanel;
	//个人定制界面
	GameObject panelDIY;


	/// <summary>
	///个人定制界面点击折合按钮弹出响应的对话框
	/// </summary>
	//装修预算菜单列表
	GameObject option1List;
	//装修风格菜单列表
	GameObject option2List;
	//用户的需求
	GameObject optionPanel;

	//选择家具界面关闭按钮
	Button btnClosed;
	GameObject selectFurnituresI;//选择家具界面

	// Use this for initialization
	void Start () {

		/// <summary>
		///获取UI界面控件
		/// </summary>
		btnChangeStyle = GameObject.Find (UIFilePath.FurnitureScenceBtnChangeStyle).GetComponent<Button>();//获取更换风格Button
		btnDIYStyle = GameObject.Find (UIFilePath.FurnitureScenceBtnDIYStyle).GetComponent<Button>();//获取个人定制Button
		btnBackBuilds = GameObject.Find (UIFilePath.FurnitureScenceBtnBackBuilds).GetComponent<Button>();//获取返回楼盘Button
		btnBackMenu = GameObject.Find (UIFilePath.FurnitureScenceBackMainUI).GetComponent<Button>();//获取返回主界面Button


		btnViewer = GameObject.Find (UIFilePath.FurnitureScenceBackground+"BtnViewer").GetComponent<Button>();//获取视觉选择Button
		btnFurniture = GameObject.Find (UIFilePath.FurnitureScenceBackground+"BtnFurniture").GetComponent<Button>();//获取添加家具Button
		btnTexture = GameObject.Find (UIFilePath.FurnitureScenceBackground+"BtnTexture").GetComponent<Button>();//获取颜色和纹理Button

		//个人定制界面三个折合按钮btnFold的获取
		btnFold1 = GameObject.Find (UIFilePath.FurnitureScenceFurniturePanelDIY+"Option1/BtnFold").GetComponent<Button>();
		btnFold2 = GameObject.Find (UIFilePath.FurnitureScenceFurniturePanelDIY+"Option2/BtnFold").GetComponent<Button>();
		btnFold3 = GameObject.Find (UIFilePath.FurnitureScenceFurniturePanelDIY+"Option3/BtnFold").GetComponent<Button>();

		
		viewerPanel = GameObject.Find (UIFilePath.FurnitureScenceBackground+"ViewerPanel");//获取视觉选择界面
		furniturerPanel = GameObject.Find (UIFilePath.FurnitureScenceFurniturerPanel);//获取家具选择界面
		textuesPanel = GameObject.Find (UIFilePath.FurnitureScenceTextuesPanel);//获取颜色和纹理选择界面
		panelDIY = GameObject.Find (UIFilePath.FurnitureScenceFurniturePanelDIY);//获取个人定制界面

		//获取个人定制界面折合按钮点击后对应的弹出窗口
		option1List = GameObject.Find (UIFilePath.FurnitureScenceFurniturePanelDIY+"Option1/OptionList");
		option2List = GameObject.Find (UIFilePath.FurnitureScenceFurniturePanelDIY+"Option2/OptionList");
		optionPanel = GameObject.Find (UIFilePath.FurnitureScenceFurniturePanelDIY+"Option3/OptionPanel");

		btnClosed = GameObject.Find (UIFilePath.FurnitureScenceSelectFurniture).GetComponent<Button>();//获取选择家具窗口关闭Button
		selectFurnituresI = GameObject.Find (UIFilePath.FurnitureScenceBackground+"SelectFurniture");//获取选择家具界面

		//隐藏要显示的界面（通过事件点击）
		viewerPanel.SetActive (false);
		furniturerPanel.SetActive (false);
		textuesPanel.SetActive (false);
		panelDIY.SetActive (false);

		option1List.SetActive (false);
		option2List.SetActive (false);
		optionPanel.SetActive (false);

		/// <summary>
		///添加相应的事件
		/// </summary>
		EventTriggerListener.GetEventTriggerListener (btnBackBuilds.gameObject).PointerDown = BackLouPanUI;//给返回楼盘按钮添加事件
		EventTriggerListener.GetEventTriggerListener (btnBackMenu.gameObject).PointerDown = BackMainMenuUI;//给返回主菜单按钮添加事件

		EventTriggerListener.GetEventTriggerListener (btnViewer.gameObject).PointerDown = SelectOfViewer;//视觉选择按钮添加事件
		EventTriggerListener.GetEventTriggerListener (btnFurniture.gameObject).PointerDown=FurnitureOfAdd;//家具按钮添加事件
		EventTriggerListener.GetEventTriggerListener (btnTexture.gameObject).PointerDown=ColorsAndTexOfSelect;//颜色和纹理添加事件

		//给个人定制和更换风格Button分别添加事件
		EventTriggerListener.GetEventTriggerListener (btnDIYStyle.gameObject).PointerDown = DIY;

		//给个人定制界面折合按钮添加事件
		EventTriggerListener.GetEventTriggerListener (btnFold1.gameObject).PointerDown = BtnFold1IsPressed;
		EventTriggerListener.GetEventTriggerListener (btnFold2.gameObject).PointerDown = BtnFold2IsPressed;
		EventTriggerListener.GetEventTriggerListener (btnFold3.gameObject).PointerDown = BtnFold3IsPressed;

		//给家具选择界面关闭Button添加事件
		EventTriggerListener.GetEventTriggerListener (btnClosed.gameObject).PointerDown = CloseWindow; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//返回楼盘的界面
	void BackLouPanUI(GameObject go){
		Application.LoadLevel ("SelectBuilds");
	}

	//返回到主界面
	void BackMainMenuUI(GameObject go){
		Application.LoadLevel ("MainMenu");
	}

	//视角选择界面
	void SelectOfViewer(GameObject go){

		if(viewerFlag==true){
			viewerPanel.SetActive (true);
			viewerFlag=false;
		}
		else{
			viewerPanel.SetActive (false);
			viewerFlag=true;
		}

	}

	//添加家具界面
	void  FurnitureOfAdd(GameObject go){

		if(furnitureFlag==true){
			furniturerPanel.SetActive(true);
			furnitureFlag=false;
		}
		else{
			furniturerPanel.SetActive (false);
			furnitureFlag=true;
		}

	}

	//颜色和纹理选择界面
	void ColorsAndTexOfSelect(GameObject go){

		if(textuesFlag==true){
			textuesPanel.SetActive (true);
			textuesFlag=false;
		}
		else{
			textuesPanel.SetActive (false);
			textuesFlag=true;
		}

	}

	/// <summary>
	///按下三个折合按钮弹出相应的对话框
	/// </summary>
	void BtnFold1IsPressed(GameObject go){

		if(option1ListFlag==true){
			option1List.SetActive (true);
			option1ListFlag=false;
		}else{
			option1List.SetActive (false);
			option1ListFlag=true;
		}

	}

	void BtnFold2IsPressed(GameObject go){

		if(option2ListFlag==true){
			option2List.SetActive (true);
			option2ListFlag=false;
		}else{
			option2List.SetActive (false);
			option2ListFlag=true;
		}

	}

	void BtnFold3IsPressed(GameObject go ){

		if(optionPanelFlag==true){
			optionPanel.SetActive (true);
			optionPanelFlag=false;
		}else{
			optionPanel.SetActive (false);
			optionPanelFlag=true;
		}

	}


	//关闭选择家具界面
	void CloseWindow(GameObject go){
		selectFurnituresI.SetActive (false);
	}

	//个人定制
	void DIY(GameObject go){

		if(personDIYFlag==true){
			panelDIY.SetActive (true);
			personDIYFlag=false;
		}else{
			panelDIY.SetActive (false);
			personDIYFlag=true;
		}
	}

}
