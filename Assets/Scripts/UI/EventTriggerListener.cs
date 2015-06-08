
/*
 * Unity3D脚本(C#):UGUI事件管理类
 * Author:秦元培
 * Date：2015年5月19日
 */
 
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class EventTriggerListener : EventTrigger
{
	//the event delegate
	public delegate void EventDelegate(GameObject go);

	//the events
	public EventDelegate PointerEnter;
	public EventDelegate PointerExit;
	public EventDelegate PointerDown;
	public EventDelegate PointerUp;
	public EventDelegate PointerClick;
	public EventDelegate BeginDrag;
	public EventDelegate Drag;
	public EventDelegate EndDrag;
	public EventDelegate Drop;
	public EventDelegate Scroll;
	public EventDelegate UpdateSelected;
	public EventDelegate Select;
	public EventDelegate Deselect;
	public EventDelegate Move;
	public EventDelegate Submit;
	public EventDelegate Cancel;

	//the static function to get the EvenetTriggerListener
	public static EventTriggerListener GetEventTriggerListener(GameObject go)
	{
		EventTriggerListener listener=go.GetComponent<EventTriggerListener>();
		if(listener==null) listener=go.AddComponent<EventTriggerListener>();
		return listener;
	}

	//the mathods of the events
	public override void OnPointerEnter(PointerEventData eventData)
	{
		if(PointerEnter!=null) PointerEnter(gameObject);
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		if(PointerExit!=null) PointerExit(gameObject);
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
		if(PointerDown!=null) PointerDown(gameObject);
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		if(PointerUp!=null) PointerUp(gameObject);
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
		if(PointerClick!=null) PointerClick(gameObject);
	}

	public override void OnBeginDrag(PointerEventData baseData)
	{
		if(BeginDrag!=null) BeginDrag(gameObject);
	}

	public override void OnEndDrag(PointerEventData baseData)
	{
		if(EndDrag!=null) EndDrag(gameObject);
	}

	public override void OnDrag(PointerEventData baseData)
	{
		if(Drag!=null) Drag(gameObject);
	}

	public override void OnScroll(PointerEventData baseData)
	{
		if(Scroll!=null) Scroll(gameObject);
	}

	public override void OnUpdateSelected(BaseEventData baseData)
	{
		if(UpdateSelected!=null) UpdateSelected(gameObject);
	}

	public override void OnSelect(BaseEventData baseData)
	{
		if(Select!=null) Select(gameObject);
	}

	public override void OnMove(AxisEventData eventData)
	{
		if(Move!=null) Move(gameObject);
	}

	public override void OnSubmit(BaseEventData baseData)
	{
		if(Submit!=null) Submit(gameObject);
	}

	public override void OnCancel(BaseEventData baseData)
	{
		if(Cancel!=null) Cancel(gameObject);
	}
}
