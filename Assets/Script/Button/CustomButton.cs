using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;

public class CustomButton : Button
{
    [SerializeField] ButtonDownEvent pressEvent = new ButtonDownEvent();
    [SerializeField] ButtonDownEvent releaseEvent = new ButtonDownEvent();
    [SerializeField] ButtonSelectEvent selectEvent = new ButtonSelectEvent();
    [SerializeField] ButtonDeselectEvent deselectEvent = new ButtonDeselectEvent();

    protected CustomButton() { }

    public override void OnPointerDown(PointerEventData eventData)
    {
        //call the base pointer event
        base.OnPointerDown(eventData);

        //if we are not using the left mouse button then break out
        if (eventData.button != PointerEventData.InputButton.Left)
            return;

        //Invoke the event
        pressEvent.Invoke();
    }
    public ButtonDownEvent onPress
    {
        get { return pressEvent; }
        set { pressEvent = value; }
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        //call the base pointer event
        base.OnPointerUp(eventData);

        //if we are not using the left mouse button then break out
        if (eventData.button != PointerEventData.InputButton.Left)
            return;

        //Invoke the event
        releaseEvent.Invoke();
    }
    public ButtonDownEvent onRelease
    {
        get { return releaseEvent; }
        set { releaseEvent = value; }
    }

    public override void OnSelect(BaseEventData eventData)
    {
        //call the base pointer event
        base.OnSelect(eventData);

        //Invoke the event
        selectEvent.Invoke();
    }
    public ButtonSelectEvent onSelect
    {
        get { return selectEvent; }
        set { selectEvent = value; }
    }

    public override void OnDeselect(BaseEventData eventData)
    {
        //call the base pointer event
        base.OnDeselect(eventData);

        //Invoke the event
        deselectEvent.Invoke();
    }
    public ButtonDeselectEvent onDeselect
    {
        get { return deselectEvent; }
        set { deselectEvent = value; }
    }

    [Serializable]
    public class ButtonDownEvent : UnityEvent { }

    [Serializable]
    public class ButtonReleaseEvent : UnityEvent { }

    [Serializable]
    public class ButtonSelectEvent : UnityEvent { }

    [Serializable]
    public class ButtonDeselectEvent : UnityEvent { }
}
